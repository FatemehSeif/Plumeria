using Application.Visitors.SaveVisitorInfo;
using Microsoft.AspNetCore.Mvc.Filters;
using UAParser;

namespace Endpoint.Utilities.Filters
{
    public class SaveVisitorFilter : IActionFilter
    {
        private readonly ISaveVisitorInfoService _saveVisitorInfoService;
        public SaveVisitorFilter(ISaveVisitorInfoService saveVisitorInfoService)
        {
            _saveVisitorInfoService = saveVisitorInfoService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //فقط روی سرور بهمون اینو نمایش میده در حالت لوکال نمیتونیم آیپی رو ببینییم
            string ip = context.HttpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
            var actionName= ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ActionName;
            var controllerName = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ControllerName;
            var userAgent = context.HttpContext.Request.Headers["User-Agent"];
            var UAparser = Parser.GetDefault();
            ClientInfo clientInfo =    UAparser.Parse(userAgent); 
            var refferer = context.HttpContext.Request.Headers["Referer"].ToString();
            var currentUrl = context.HttpContext.Request.Path;
            var Request = context.HttpContext.Request;
            var visitorId = context.HttpContext.Request.Cookies["VisitorId"];
            if (visitorId == null)
            {
                visitorId= Guid.NewGuid().ToString(); 
                context.HttpContext.Response.Cookies.Append("VisitorId",visitorId, new
                    Microsoft.AspNetCore.Http.CookieOptions
                {
                    Path = "/",
                    HttpOnly = true,    
                    Expires = DateTime.Now.AddDays(30),
                });
            }
            _saveVisitorInfoService.Execute(new RequestSaveVisitorInfoDto
            {
                Browser = new VisitorVersionDto
                {
                    Family = clientInfo.UA.Family,
                    Version = $"{clientInfo.UA.Major}.{clientInfo.UA.Minor}.{clientInfo.UA.Patch}"
                },
                CurrentLink = currentUrl,
                Device = new DeviceDto
                {
                    Brand = clientInfo.Device.Brand,
                    Family = clientInfo.Device.Family,
                    IsSpider = clientInfo.Device.IsSpider,
                    Model = clientInfo.Device.Model
                },
                OperationSystem = new VisitorVersionDto
                {
                    Family = clientInfo.OS.Family,
                    Version = $"{clientInfo.UA.Major}.{clientInfo.UA.Minor}.{clientInfo.UA.Patch}"
                },
                Ip = ip,
                Method = Request.Method,
                PhysicalPath = $"{controllerName}/{actionName}",
                Protocol= Request.Protocol,
                RefferLink= refferer ,
                VisitorId = visitorId,  
        
            }) ;
        }
    }
}
