using Application.BasketsService;
using Azure.Core;
using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Endpoint.Utilities;
using Endpoint.Utilities;

namespace Endpoint.Models.ViewComponents
{
    public class BasketComponent : ViewComponent
    {
        private readonly IBasketService basketService;
        public BasketComponent(IBasketService basketService)
        {
            this.basketService = basketService;
        }
        private ClaimsPrincipal userClaimsPrincipal => ViewContext?.HttpContext?.User;
        public IViewComponentResult Invoke()
        {
            BasketDto basket = null;
            if (User.Identity.IsAuthenticated)
            {
                basket = basketService.GetBasketForUser(ClaimUtility.GetUserId(userClaimsPrincipal));
            }
            else
            {
                string basketCookieName = "BasketId";
                if (Request.Cookies.ContainsKey(basketCookieName))
                {
                    var buyerId = Request.Cookies[basketCookieName];
                    basket = basketService.GetBasketForUser(buyerId);
                }

            }
            return View(viewName: "BasketComponent", model: basket);
        }
    }

}