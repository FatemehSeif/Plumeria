using Application.Catalogs.CatalogItems.UriComposer;
using Application.Dtos;
using Application.Interfaces.Contexts;
using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogItems.GetCatalogItemPLP
{
    public interface IGetCatalogIItemPLPService
    {
        PaginatedItemsDto<CatalogPLPDto> Execute(CatlogPLPRequestDto request);
    }

    public class GetCatalogIItemPLPService : IGetCatalogIItemPLPService
    {
        private readonly IDataBaseContext context;
        private readonly IUriComposerService uriComposerService;
        
        public GetCatalogIItemPLPService(IDataBaseContext context
            , IUriComposerService uriComposerService)
        {
            this.context = context;
            this.uriComposerService = uriComposerService;
        }
        public PaginatedItemsDto<CatalogPLPDto> Execute(CatlogPLPRequestDto request)
        {
            int rowCount = 0;
            var query = context.CatalogItems
                .Include(p => p.Discounts)
                .Include(p => p.CatalogItemImages)
                .OrderByDescending(p => p.Id)
                .AsQueryable();

            if (request.brandId != null)
            {
                query = query.Where(p => request.brandId.Any(b => b == p.CatalogBrandId));
                
            }

            if (request.CatalogTypeID != null)
            {
                query = query.Where(p => p.CatalogTypeId == request.CatalogTypeID);
            }

            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                query = query.Where(p => p.Name.Contains(request.SearchKey)
                || p.Description.Contains(request.SearchKey));
            }
           

            if (request.AvailableStock == true)
            {
                query = query.Where(p => p.AvailableStock > 0);
            }

            if (request.SortType == SortType.Everything)
            {
                
                   query = query.Where(p => p.AvailableStock > 0);
            }

            if (request.SortType == SortType.Prof)
            {
                query = query.Where(p => p.CatalogBrandId == 1); 
            }
            if (request.SortType == SortType.Smart)
            {
                query = query.Where(p => p.CatalogBrandId == 2);
            }
            if (request.SortType == SortType.LifeGuard)
            {
                query = query.Where(p => p.CatalogBrandId == 3);
            }
            if (request.SortType == SortType.Class1)
            {
                query = query.Where(p => p.CatalogBrandId == 4);
            }


            if (request.SortType == SortType.MostPopular)
            {
                query = query.Include(p => p.CatalogItemFavourites)
                    .OrderByDescending(p => p.CatalogItemFavourites.Count());
            }
            if (request.SortType == SortType.MostVisited)
            {
                query = query
                    .OrderByDescending(p => p.VisitCount);
            }

            if (request.SortType == SortType.newest)
            {
                query = query
                    .OrderByDescending(p => p.Id);
            }

            if (request.SortType == SortType.cheapest)
            {
                query = query
                   
                    .OrderBy(p => p.Price);
            }

            if (request.SortType == SortType.mostExpensive)
            {
                query = query
                 
                    .OrderByDescending(p => p.Price);
            }

            if (request.SortType == SortType.SkinCare)
            {
                query= query.Where(p=> p.CatalogTypeId == 6);   
            }

            if (request.SortType == SortType.HairCare)
            {
                query = query.Where(p => p.CatalogTypeId == 2);
            }
            if (request.SortType == SortType.BodyCare)
            {
                query = query.Where(p => p.CatalogTypeId == 3);
            }
            if (request.SortType == SortType.Perfume)
            {
                query = query.Where(p => p.CatalogTypeId == 4);
            }

            if (request.SortType == SortType.TeethCare)
            {
                query = query.Where(p => p.CatalogTypeId == 5);
            }


            var data = query.PagedResult(request.page, request.pageSize, out rowCount)
                .ToList()
                .Select(p => new CatalogPLPDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Rate = 4,
                    Slug = p.Slug,
                    Image = p.CatalogItemImages != null && p.CatalogItemImages.Any()
               ? uriComposerService.ComposeImageUri(p.CatalogItemImages.FirstOrDefault().Src)
               : null, // Or a default image URL
                    AvailableStock = p.AvailableStock,
                    CatalogTypeID = p.CatalogTypeId ,
                   brandId = request.brandId, 


                }).ToList();
            return new PaginatedItemsDto<CatalogPLPDto>(request.page, request.pageSize, rowCount, data);
        }
    }


    public class CatlogPLPRequestDto
    {
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 10;
        // public int? CatalogTypeId { get; set; }
        public string Slug { get; set; }
        public int? CatalogTypeID { get; set; }
        public int[] brandId { get; set; }
        public bool AvailableStock { get; set; }
        public string SearchKey { get; set; }
        public SortType SortType { get; set; }
        public int? minPrice { get; set; }
        public int? maxPrice { get; set; }
    }

    public enum SortType
    {
        /// <summary>
        /// بدونه مرتب سازی
        /// </summary>
        None = 0,
        /// <summary>
        /// پربازدیدترین
        /// </summary>
        MostVisited = 1,
        /// <summary>
        /// پرفروش‌ترین
        /// </summary>
        Prof = 2,
        /// <summary>
        /// محبوب‌ترین
        /// </summary>
        MostPopular = 3,
        /// <summary>
        ///  ‌جدیدترین
        /// </summary>
        newest = 4,
        /// <summary>
        /// ارزان‌ترین
        /// </summary>
        cheapest = 5,
        /// <summary>
        /// گران‌ترین
        /// </summary>
        mostExpensive = 6,
        Everything= 7,
        Smart = 8,
        LifeGuard= 9 ,  
        Class1= 10 , 
        SkinCare = 11 , 
        HairCare =12 ,  
        BodyCare = 13 ,
        Perfume = 14 ,
        TeethCare = 15 ,
    }
    public class CatalogPLPDto
    {
        public string Slug { get; set; }    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public byte Rate { get; set; }
        public int AvailableStock { get; set; }

        public int? CatalogTypeID { get; set; }
        public int[] brandId { get; set; }


    }
}
