using Application.Catalogs.CatalogItems.GetCatalogItemPLP;
using Application.Catalogs.CatalogTypes;
using Application.HomePageService;
using Endpoint.Models;
using Endpoint.Utilities.Filters;
using Infrastructure.CacheHelpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Presistance.Migrations;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace Endpoint.Controllers
{
	[ServiceFilter(typeof(SaveVisitorFilter))]    
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IHomePageService homePageService;
        private readonly IDistributedCache _cache;
        private readonly IGetCatalogIItemPLPService getCatalogIItemPLPService;
        public HomeController(ILogger<HomeController> logger, IHomePageService homePageService, IDistributedCache distributedCache,
             IGetCatalogIItemPLPService getCatalogIItemPLPService)
		{
			_cache = distributedCache;	
			this.homePageService = homePageService;	
			_logger = logger;
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
		
		}

		public IActionResult Index()
        {
            HomePageDto homePageData = new HomePageDto();

            // Get the price range values from the request
            var minPrice = Request.Query.ContainsKey("minPrice") ? int.Parse(Request.Query["minPrice"]) : (int?)null;
            var maxPrice = Request.Query.ContainsKey("maxPrice") ? int.Parse(Request.Query["maxPrice"]) : (int?)null;

            // Generate a cache key that includes the price range
            var cacheKey = CacheHelper.GenerateHomePageCacheKey(minPrice, maxPrice);

            var homePageCache = _cache.GetAsync(cacheKey).Result; // Use the new cache key

            if (homePageCache != null)
            {
                homePageData = JsonSerializer.Deserialize<HomePageDto>(homePageCache);
            }
            else
            {
                // Call GetData with the price range
                homePageData = homePageService.GetData(minPrice, maxPrice);

                // Set the cache with the price range values
                string jsonData = JsonSerializer.Serialize(homePageData);
                byte[] encodedJson = Encoding.UTF8.GetBytes(jsonData);
                var options = new DistributedCacheEntryOptions()
                    .SetSlidingExpiration(CacheHelper.DefaultCacheDuration);

                _cache.SetAsync(cacheKey, encodedJson, options); // Use the new cache key
            }

            return View(homePageData);
        }



        [Authorize]
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
