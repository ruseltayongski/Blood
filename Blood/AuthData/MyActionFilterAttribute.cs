using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.AuthData
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await base.OnActionExecutionAsync(context, next);

            var controller = context.Controller as Controller;
            if (controller == null) return;

            controller.ViewBag.action_name = controller.RouteData.Values["action"].ToString();
            controller.ViewBag.controller_name = controller.RouteData.Values["controller"].ToString();

        }
    }
}
