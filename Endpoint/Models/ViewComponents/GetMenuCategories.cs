using Application.Catalogs.CatalogItems.GetMenuItem;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Models.ViewComponents
{
    public class GetMenuCategories : ViewComponent
    {
        private readonly IGetMenuItemService getmenuItemService;
        public GetMenuCategories(IGetMenuItemService getMenuItemService)
        {
            this.getmenuItemService = getMenuItemService;   
        }

        public IViewComponentResult Invoke ()
        {
            var data = getmenuItemService.Execute();
            return View(viewName: "GetMenuCategories",  model : data);
        }

       
    }
}
