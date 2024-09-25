using firstlessen.Models.Pages;
using firstlessen.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using EPiServer.Web.Routing;

namespace firstlessen.Business
{
    public class PageContextActionFilter : IResultFilter
    {
        private readonly PageViewCotextFactory _contextFactory;

        public PageContextActionFilter(PageViewCotextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var controller = context.Controller as Controller;
            var viewModel = controller?.ViewData.Model;

            if (viewModel is IPageViewModel<SitePageData> model)
            {
                var currentContentLink = context.HttpContext.GetContentLink();

                var layoutModel = model.Layout ?? _contextFactory.CreatLaoutModel(currentContentLink, context.HttpContext);

                if (context.Controller is IModifyLayout layoutController)
                {
                    layoutController.ModifyLayout(layoutModel);
                }

                model.Layout = layoutModel;
            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
    

}
