
using Application.BasketsService;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalogItems.GetCatalogItemPLP;
using Application.Catalogs.CatalogItems.UriComposer;
using Application.Catalogs.CatalogTypes;
using Application.Interfaces.Contexts;
using Domain.Banners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.HomePageService
{
    public interface IHomePageService
    {
        HomePageDto GetData(int? minPrice, int? maxPrice);
    }

   
        public class HomePageService : IHomePageService
        {
            private readonly IDataBaseContext context;
            private readonly IUriComposerService uriComposerService;
            private readonly IGetCatalogIItemPLPService getCatalogIItemPLPService;
      
            public HomePageService(IDataBaseContext context
                , IUriComposerService uriComposerService
                , IGetCatalogIItemPLPService getCatalogIItemPLPService
                , IBasketService basketService
                )
            {
                this.context = context;
                this.uriComposerService = uriComposerService;
                this.getCatalogIItemPLPService = getCatalogIItemPLPService;
           
         
            }


            public HomePageDto GetData(int? minPrice, int? maxPrice)
            {
                var banners = context.Banners.Where(p => p.IsActive == true)
                    .OrderBy(p => p.Priority)
                    .ThenByDescending(p => p.Id)
                    .Select(p => new BannerDto
                    {
                        Id = p.Id,
                        Image = uriComposerService.ComposeImageUri(p.Image),
                        Link = p.Link,
                        Position = p.Position,
                    }).ToList();

                var Bestselling = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
                {
                    AvailableStock = true,
                    page = 1,
                    pageSize = 20,
                    SortType = SortType.Prof,
                    minPrice = minPrice,
                    maxPrice = maxPrice
                }).Data.ToList();

                var MostPopular = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
                {
                    AvailableStock = true,
                    page = 1,
                    pageSize = 20,
                    SortType = SortType.MostPopular,
                    minPrice = minPrice,
                    maxPrice = maxPrice
                }).Data.ToList();


            var MostVisited = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.MostVisited, // Assuming MostVisited is a valid SortType
                minPrice = minPrice,
                maxPrice = maxPrice
            }).Data.ToList();

             var Newest = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
             {
                 AvailableStock = true,
                 page = 1,
                 pageSize = 20,
                 SortType = SortType.newest, // Assuming MostVisited is a valid SortType
                 minPrice = minPrice,
                 maxPrice = maxPrice
             }).Data.ToList();

            var Cheapest = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.cheapest, // Assuming MostVisited is a valid SortType
                minPrice = minPrice,
                maxPrice = maxPrice
               }).Data.ToList();

             var catalogs= getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
             {
                 AvailableStock = true,
                 page = 1,
                 pageSize = 20,
                 SortType = SortType.Everything, // Assuming MostVisited is a valid SortType
                 minPrice = minPrice,
                 maxPrice = maxPrice
             }).Data.ToList();

            var Smart = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.Smart, // Assuming MostVisited is a valid SortType
                minPrice = minPrice,
                maxPrice = maxPrice
            }).Data.ToList();



            var Prof = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.Prof, // Assuming MostVisited is a valid SortType
                minPrice = minPrice,
                maxPrice = maxPrice
            }).Data.ToList();
            var LifeGuard = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.LifeGuard, // Assuming MostVisited is a valid SortType
                minPrice = minPrice,
                maxPrice = maxPrice
            }).Data.ToList();

            var Class1 = getCatalogIItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.Class1, // Assuming MostVisited is a valid SortType
                minPrice = minPrice,
                maxPrice = maxPrice
            }).Data.ToList();


            return new HomePageDto
                {
              
                catalogs = catalogs, 
                Cheapest = Cheapest,    
                    Banners = banners,
                  Newest= Newest,   
                    bestSellers = Bestselling,
                    MostPopular = MostPopular,
                   MostVisited = MostVisited,
                    minPrice = minPrice,
                    maxPrice = maxPrice,
                    Class1 = Class1,    
                    Smart= Smart,   
                    LifeGuard = LifeGuard,  
                    Prof   = Prof,  
                };
            }
        }

        public class HomePageDto
        {
            public List<BannerDto> Banners { get; set; }
            public List<CatalogPLPDto> MostPopular { get; set; }
            public List<CatalogPLPDto> bestSellers { get; set; }
            public List<CatalogPLPDto> MostVisited { get; set; }
            public List<CatalogPLPDto> Newest {  get; set; }     
            public List<CatalogPLPDto> Cheapest { get; set; }  
            public List<CatalogPLPDto> Smart {  get; set; }  
            public List<CatalogPLPDto> LifeGuard { get; set; }  
            public List<CatalogPLPDto> Class1 { get; set; } 
            public List<CatalogPLPDto> Prof {  get; set; }  
            public List<CatalogPLPDto>  catalogs { get; set; }      
            public int? minPrice { get; set; }
            public int? maxPrice { get; set; }

        }



    public class BannerDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public Position Position { get; set; }
    }
}
