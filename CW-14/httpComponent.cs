using CW_14.Models;
using Microsoft.AspNetCore.Mvc;

namespace CW_14
{
    public class HttpViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpDetails httpDetails = new HttpDetails();
            httpDetails.Ip = HttpContext.Connection.RemoteIpAddress.ToString();
            httpDetails.HttpMethod = HttpContext.Request.Method;
             

            return await Task.FromResult((IViewComponentResult)View("Component",httpDetails));
        }
    }
}
