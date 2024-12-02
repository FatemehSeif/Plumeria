
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalogItems.GetCatalogItemPLP;
using Application.Commetns.Commands;
using Application.Commetns.Queries;
using Domain.Catalogs;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using Presistance.Migrations;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using static Application.Commetns.Commands.SendCommentHandler;

namespace WebSite.EndPoint.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGetCatalogIItemPLPService getCatalogIItemPLPService;
       private readonly IGetCatalogItemPDPService getCatalogItemPDPService;
        private readonly IMediator mediator;   
        
        public ProductController(IGetCatalogIItemPLPService
            getCatalogIItemPLPService 
             , IGetCatalogItemPDPService getCatalogItemPDPService
            , IMediator mediator    
              )
        {
            this.mediator = mediator;   
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
            this.getCatalogItemPDPService = getCatalogItemPDPService;
        }
        public IActionResult Index( CatlogPLPRequestDto catalogPLPRequestDto)
        {
           
            var data = getCatalogIItemPLPService.Execute(catalogPLPRequestDto);
            return View(data);
        }
        //public IActionResult Details( string Slug )
        //{


        //    var data = getCatalogItemPDPService.Execute(Slug);
        //    GetCommentOfCatalogItemRequest itemDto = new GetCommentOfCatalogItemRequest()
        //    {
        //        CataLogItemId = data.Id,
        //    };
        //    var result = mediator.Send(itemDto).Result;

        //    return View(data);
        //}



        //public IActionResult SendComment(CommentDto commentDto, string Slug)
        //{
        //    SendCommentCommand sendComment = new SendCommentCommand(commentDto);
        //    var result = mediator.Send(sendComment).Result;
        //    return RedirectToAction(nameof(Comments), new { Slug = Slug });


        //}


        public IActionResult SendComment(ComDto commentDto, string Slug)
        {

            SendCommentCommand sendComment = new SendCommentCommand(commentDto);
            var result = mediator.Send(sendComment).Result;
            return RedirectToAction(nameof(Details), new { Slug = Slug });

        }



        [HttpGet]
        public IActionResult FilterByCategory(FilterCat filter)
        {
            // Ensure that filter properties are set, fallback to defaults if needed
            if (filter == null)
            {
                filter = new FilterCat();
            }

        

            // Assuming you have a method to transform FilterCat to your request object
            var request = new CatlogPLPRequestDto
            {
                Slug = filter.Slug,
                CatalogTypeID = filter.CatalogTypeID,
                page = filter.page,
                pageSize = filter.pageSize,
                AvailableStock = filter.AvailableStock, 
          
                
            };

            // Execute the service method with the request object
            var result = getCatalogIItemPLPService.Execute(request);

            // Return the filtered view
            return View("FilterByCategory", result);
        }



        public IActionResult Details(string Slug)
        {


            var data = getCatalogItemPDPService.Execute(Slug);

            GetCommentOfCatalogItemRequest itemDto = new GetCommentOfCatalogItemRequest()
            {
                CataLogItemId = data.Id,
            };
            var result = mediator.Send(itemDto).Result;

            return View(data);
        }

        //public async Task<IActionResult> Com(int catalogItemId)
        //{
        //    // ارسال Query به Mediator برای دریافت کامنت‌ها
        //    var comments = await mediator.Send(new GetCommentsByCatalogItemIdQuery(catalogItemId));

        //    // ارسال کامنت‌ها به View
        //    var model = new Comment
        //    {
        //        Comments = comments
        //    };

        //    return View(model);
        //}


        
        [HttpGet]
        public IActionResult SortedByBrandProf()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.Prof, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }

        [HttpGet]
        public IActionResult SortedByBrandSmart()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.Smart, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }
        [HttpGet]
        public IActionResult SortedByBrandClass1()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.Class1, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }

        [HttpGet]
        public IActionResult SortedByBrandLifeGuard()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.LifeGuard, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }


        [HttpGet]
        public IActionResult SkinCare()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.SkinCare, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }
        [HttpGet]
        public IActionResult HairCare()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.HairCare, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }

        [HttpGet]
        public IActionResult BodyCare()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.BodyCare, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }
        [HttpGet]
        public IActionResult Perfume()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.Perfume, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }
        [HttpGet]
        public IActionResult TeethCare()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.TeethCare, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }
        [HttpGet]
        public IActionResult Newest()
        {
            var request = new CatlogPLPRequestDto
            {
                SortType = SortType.newest, // Set to Prof for filtering
                page = 1,
                pageSize = 10
            };

            var result = getCatalogIItemPLPService.Execute(request);

            return View("SortedByBrand", result); // Specify the correct view name if necessary

        }

        public class FilterCat
        {
            public int categoryId { get; set; }
            public string Slug { get; set; }
           public int page { get; set; } =1;
            public int pageSize { get; set; } = 10; 
            public int? CatalogTypeID { get; set; }
     
            public bool AvailableStock { get; set; }
       


        }

     


    }
}
