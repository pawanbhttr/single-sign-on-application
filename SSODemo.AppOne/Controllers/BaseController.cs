using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SSODemo.AppOne.Controllers
{
    public abstract class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var _bool = context.HttpContext.User.Identity?.IsAuthenticated;
            if (!(_bool ?? false))
                context.Result = Forbid();

            base.OnActionExecuting(context);
        }
    }
}
