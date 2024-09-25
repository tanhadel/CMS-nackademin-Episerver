using System.ComponentModel.DataAnnotations;
using static firstlessen.Globals;

namespace firstlessen.Models.Pages
{
	[ContentType(
	   GUID = "A9F5F4B0-DDEA-4BF0-B744-DB5B688DD2D0",
	   GroupName = GroupNames.Specialized
   )]
	[ImageUrl("/pages/CMS-icon-page-03.png")]

	public class SettingsPage : SitePageData
	{
		[Display (
			GroupName = SystemTabNames.Content,
			Order = 10
		)]
		public virtual ContentReference SlideshowContainer { get; set; }
    }
}
