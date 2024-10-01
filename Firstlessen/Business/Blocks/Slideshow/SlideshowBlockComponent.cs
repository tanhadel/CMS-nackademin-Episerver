using EPiServer.Web;
using EPiServer.Web.Mvc;
using firstlessen.Business.Components.Slideshow;
using firstlessen.Models.Block;
using firstlessen.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace firstlessen.Business.Blocks.Slideshow
{
    public class SlideshowBlockComponent : AsyncBlockComponent<SlideshowBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(SlideshowBlock currentContent)
        {
            var model = new SlideshowBlockViewtModel();

            foreach (var item in currentContent.Slideshow.FilteredItems.Select(x => x.LoadContent()))
            {
                if (item is SlideshowPage)
                {
                    var page = item as SlideshowPage;

                    model.Pages.Add(page);
                }
            }

            return await Task.FromResult(View("~/Business/Block/Slideshow/Defaul.cshtml", model));
        }
    }
}
