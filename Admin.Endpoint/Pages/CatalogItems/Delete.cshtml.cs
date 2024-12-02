using Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Discounts;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Endpoint.Pages.CatalogItems
{
    public class DeleteModel : PageModel
    {
        
            private readonly ICatalogItemService _catalogItemService;
            private readonly IAddNewCatalogItemService addNewCatalogItemService;
            public DeleteModel(ICatalogItemService catalogItemService,
                IAddNewCatalogItemService addNewCatalogItemService
                
                )
            {
            this.addNewCatalogItemService = addNewCatalogItemService;
            _catalogItemService = catalogItemService;
            }

            [BindProperty]
            public AddNewCatalogItemDto Data { get; set; }

            public async Task OnGetAsync(int id)
            {
                Data = addNewCatalogItemService.GetById(id);

              //if (Data == null)
              //{
              //  return NotFound();

              //}
            }

            public async Task<JsonResult> OnPostAsync(int id)
            {
                var result = addNewCatalogItemService.Delete(id);
                return new JsonResult(result);
            }
        }
    }

