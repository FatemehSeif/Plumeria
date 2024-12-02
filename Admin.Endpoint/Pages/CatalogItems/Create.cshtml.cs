using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using Application.Catalogs.CatalogItems;
using Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Infrastructure.ExternalApi.ImageServer;
using Application.Dtos;

namespace Admin.Endpoint.Pages.CatalogItems
{
    public class CreateModel : PageModel
    {
        private readonly IAddNewCatalogItemService addNewCatalogItemService;
        private readonly ICatalogItemService catalogItemService;
        private readonly IImageUploadService imageUploadService;

        public CreateModel(IAddNewCatalogItemService addNewCatalogItemService
            , ICatalogItemService catalogItemService
            , IImageUploadService imageUploadService)
        {
            this.addNewCatalogItemService = addNewCatalogItemService;
            this.catalogItemService = catalogItemService;
            this.imageUploadService = imageUploadService;
        }

        public required SelectList Categories { get; set; }
        public required SelectList Brands { get; set; }

        [BindProperty]
        public AddNewCatalogItemDto Data { get; set; }
        [BindProperty]
        public List<IFormFile> Files { get; set; }


        public void OnGet()
        {
            Categories = new SelectList(catalogItemService.GetCatalogType(), "Id", "Type");
            Brands = new SelectList(catalogItemService.GetBrand(), "Id", "Brand");
            if (Categories == null)
            {
                throw new NotImplementedException();
            }
        }



        public JsonResult OnPost()
        {
           
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new JsonResult(new BaseDto<int>(false, allErrors.Select(p => p.ErrorMessage).ToList(), 0));
            }
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                Files.Add(file);
            }
            List<AddNewCatalogItemImage_Dto> images = new List<AddNewCatalogItemImage_Dto>();
            if (Files.Count > 0)
            {
                //Upload 
                var result = imageUploadService.Upload(Files);
                foreach (var item in result)
                {
                    images.Add(new AddNewCatalogItemImage_Dto { Src = item });
                }
            }
            Data.Images = images;
            var resultService = addNewCatalogItemService.Execute(Data);
            return new JsonResult(resultService);
        }

    }





    public class UploadDto
    {
        public bool Status { get; set; }
        public List<string> FileNameAddress { get; set; }
    }
}
