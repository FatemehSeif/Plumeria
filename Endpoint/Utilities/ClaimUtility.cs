using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Endpoint.Utilities
{
    public static class ClaimUtility
    {
        public static string basketCookieName = "BasketId";
        public static string GetUserId(ClaimsPrincipal User)
        {

            var claimsIdentity = User.Identity as ClaimsIdentity;
            var myuser = claimsIdentity.Claims;
            var userId = myuser.FirstOrDefault(p => p.Type == "sub")?.Value;
            //string userId1= claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return userId;
        }
    }
}
