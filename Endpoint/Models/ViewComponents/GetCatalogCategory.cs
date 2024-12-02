using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalogItems.GetCatalogItemPLP;
using Application.Catalogs.CatalogTypes;
using Microsoft.AspNetCore.Mvc;
using Presistance.Migrations;

namespace Endpoint.Models.ViewComponents
{
    public class GetCatalogCategory : ViewComponent
    {
    
        private readonly IGetCatalogIItemPLPService catalogIItemPLPService; 
        public GetCatalogCategory( IGetCatalogIItemPLPService catalogIItemPLPService)
        {

            this.catalogIItemPLPService = catalogIItemPLPService;   

        }

        public IViewComponentResult Invoke(int categoryId, int page = 1, int pageSize = 10)
        {
            var request = new CatlogPLPRequestDto
            {
                
                CatalogTypeID = categoryId,
                page = page,
                pageSize = pageSize
            };
            var result = catalogIItemPLPService.Execute(request);
            return View("GetCatalogCategory", result);

        }

    }
}
