using CoreFilter_0.Models.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoreFilter_0.Filters
{
    public class ControlPropertyFilter : ActionFilterAttribute
    {

        //Action calısmadan önce
        public override void OnActionExecuting(ActionExecutingContext context)
        {
           
            //context.ActionArguments
            //context.HttpContext

            KeyValuePair<string, object> result = context.ActionArguments.FirstOrDefault(x => x.Key == "model");

            Category category = result.Value as Category;

            if (category.CategoryName == null)
            {
                //


                context.Result = new RedirectResult("/Home/Index");
            }
                

            base.OnActionExecuting(context);
        }

    }
}
