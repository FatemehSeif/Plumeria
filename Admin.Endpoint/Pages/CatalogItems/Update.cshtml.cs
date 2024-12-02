using Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using Infrastructure.ExternalApi.ImageServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Admin.Endpoint.Pages.CatalogItems
{
    public class UpdateModel : PageModel
    {
        private readonly ICatalogItemService _catalogItemService;
        private readonly IImageUploadService _imageUploadService;
        private readonly IAddNewCatalogItemService addNewCatalogItemService;
        public UpdateModel(ICatalogItemService catalogItemService, IImageUploadService imageUploadService,
              IAddNewCatalogItemService addNewCatalogItemService
            )

        {
            this.addNewCatalogItemService = addNewCatalogItemService;   
            _catalogItemService = catalogItemService;
            _imageUploadService = imageUploadService;
        }

        [BindProperty]
        public AddNewCatalogItemDto Data { get; set; }

        [BindProperty]
        public List<IFormFile> Files { get; set; }

        public required SelectList Categories { get; set; }
        public required SelectList Brands { get; set; }

        //public async Task OnGetAsync(int id)
        //{
        //    Categories = new SelectList(_catalogItemService.GetCatalogType(), "Id", "Type");
        //    Brands = new SelectList(_catalogItemService.GetBrand(), "Id", "Brand");

        //    Data = addNewCatalogItemService.GetById(id);
        //    //if (Data == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //}

        public void OnGet(int id)
        {
            Categories = new SelectList(_catalogItemService.GetCatalogType(), "Id", "Type");
            Brands = new SelectList(_catalogItemService.GetBrand(), "Id", "Brand");
            if (Categories == null)
            {
                throw new NotImplementedException();
            }
            Data = addNewCatalogItemService.GetById(id);
        
        }



        public JsonResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new BaseDto<int>(false, ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList(), 0));
            }

            // Handle Image Uploads
            if (Request.Form.Files.Count > 0)
            {
                Files = Request.Form.Files.ToList();
                var r =  _imageUploadService.Upload(Files); // Assuming async method
                Data.Images = r.Select(i => new AddNewCatalogItemImage_Dto { Src = i }).ToList();
            }

            var result = addNewCatalogItemService.Update(id, Data);
            return new JsonResult(result);
        }
    }
}

