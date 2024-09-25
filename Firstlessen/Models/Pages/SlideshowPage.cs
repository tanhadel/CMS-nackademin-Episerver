using EPiServer.Web;
using static firstlessen.Globals;
using System.ComponentModel.DataAnnotations;

namespace firstlessen.Models.Pages
{
	[ContentType(
		GUID = "D0CA284A-F6EE-40D4-8C85-A7584EEDFE39",
		GroupName = GroupNames.Specialized,
		DisplayName = "Slideshow",
		Description = "This is a slideshow template"
	)]
	[ImageUrl("/pages/CMS-icon-page-07.png")]
	public class SlideshowPage :SitePageData
	{
		[Display(
			GroupName = SystemTabNames.Content,
			Order = 10
		)]
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
		public virtual string HeadLine { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
		public virtual string Text { get; set; }
    }
	
}
