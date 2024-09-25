﻿using EPiServer.Web;
using firstlessen.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace firstlessen.Business.Components.Slideshow
{
	public class SlideshowViewComponent : ViewComponent
	{
		private readonly IContentLoader _contentLoader;
		public SlideshowViewComponent(IContentLoader contentLoader)
		{
			_contentLoader = contentLoader;
		}


		public IViewComponentResult Invoke (IContentLoader contentLoader)
		{
            var startPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage);
            var model = new SlideshowViewComponentModel();

			if (startPage.Content != null)
			{
                foreach (var item in startPage.Content.FilteredItems.Select(x => x.LoadContent())) 
                {
					if (item is SlideshowPage)
					{
						var page = item as SlideshowPage;
						
						model.Pages.Add(page);
					}
                    
                }
            }
			return View("~/Business/Components/Slideshow/Default.cshtml", model);

		}

	}
}
