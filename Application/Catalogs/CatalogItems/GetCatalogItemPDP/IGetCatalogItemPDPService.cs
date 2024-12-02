using Application.BasketsService;
using Application.Catalogs.CatalogItems.UriComposer;
using Application.Commetns.Commands;
using Application.Commetns.Queries;
using Application.Interfaces.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Application.Catalogs.CatalogItems.GetCatalogItemPDP.GetCatalogItemPDPService;




namespace Application.Catalogs.CatalogItems.GetCatalogItemPDP
{
    public interface IGetCatalogItemPDPService
    {
        CatalogItemPDPDto Execute(string Slug);
    }

    public class GetCatalogItemPDPService : IGetCatalogItemPDPService
    {
        private readonly IDataBaseContext context;
        private readonly IUriComposerService uriComposerService;
        private readonly IBasketService basketService;
       // private readonly IMediator mediator;    

        public GetCatalogItemPDPService(IDataBaseContext context, IUriComposerService uriComposerService,
            IBasketService basketService)
        {
            this.context = context;
            this.uriComposerService = uriComposerService;
            this.basketService = basketService; 
        }
        public CatalogItemPDPDto Execute(string Slug)
        {
            var catalogitem = context.CatalogItems
                .Include(p => p.CatalogItemFeatures)
                .Include(p => p.CatalogItemImages)
                .Include(p => p.CatalogType)
                .Include(p => p.CatalogBrand)
                .Include(p => p.Discounts)
                
                .SingleOrDefault(p => p.Slug == Slug);

            // Check if catalogitem is null
            if (catalogitem == null)
            {
                // Handle the case when no item is found
                throw new KeyNotFoundException($"No catalog item found with slug: {Slug}");
                // Alternatively, you could return null or a default value if appropriate
            }

            // Increment visit count
            catalogitem.VisitCount += 1;
            context.SaveChanges();

            var feature = catalogitem.CatalogItemFeatures
                .Select(p => new PDPFeaturesDto
                {
                    Group = p.Group,
                    Key = p.Key,
                    Value = p.Value
                }).ToList()
                .GroupBy(p => p.Group);

            var similarCatalogItems = context
                .CatalogItems
                .Include(p => p.CatalogItemImages)
                .Where(p => p.CatalogTypeId == catalogitem.CatalogTypeId)
                .Take(10)
                .Select(p => new SimilarCatalogItemDto
                {
                    Id = p.Id,
                    Images = uriComposerService.ComposeImageUri(p.CatalogItemImages.FirstOrDefault().Src),
                    Price = p.Price,
                    Name = p.Name,
                    Slug = p.Slug,  
                }).ToList();

            var comm = context
                .CatalogItemComments
                .Where(p=> p.CatalogItemId== catalogitem.Id)
               .Select(p=> new CommentDto
               {
                   Email = p.Email, 
                   CatalogItemId = catalogitem.Id,
                   Comment = p.Comment, 
                   CreatedAt = DateTime.Now,    
                   Rating = p.Rating,   
                   Title = p.Title, 

               }).ToList(); 
           
            


            return new CatalogItemPDPDto
            {
                
               
                Slug = Slug,    
                Features = feature,
                SimilarCatalogs = similarCatalogItems,
                Id = catalogitem.Id,
                Name = catalogitem.Name,
                Brand = catalogitem.CatalogBrand?.Brand, // Use null-conditional operator
                Type = catalogitem.CatalogType?.Type, // Use null-conditional operator
                Price = catalogitem.Price,
                Description = catalogitem.Description,
                Images = catalogitem.CatalogItemImages.Select(p => uriComposerService.ComposeImageUri(p.Src)).ToList(),
                OldPrice = catalogitem.OldPrice, // Ensure OldPrice is set correctly
                PercentDiscount = catalogitem.PercentDiscount,
                
                
            };
        }



        public class CatalogItemPDPDto
        {
                public string Email { get; set; }   
            public string Slug { get; set; }
            public int Quantity { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Brand { get; set; }
            public int Price { get; set; }
            public int? OldPrice { get; set; }
            public int? PercentDiscount { get; set; }
            public List<string> Images { get; set; }
            public string Description { get; set; }
            public IEnumerable<IGrouping<string, PDPFeaturesDto>> Features { get; set; }
            public List<SimilarCatalogItemDto> SimilarCatalogs { get; set; }
      
            public ComDto Com { get; set; } 
           public List<ComDto> Coms { get; set; }

        }

     
    }
    public class PDPFeaturesDto
    {
        public string Group { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class ComDto
    {
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public int CatalogItemId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Rating { get; set; }

    }
    public class SimilarCatalogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Images { get; set; }
        public string Slug { get; set; }
     
        
    }

}