using System.ComponentModel.DataAnnotations;
using static firstlessen.Models.Pages.SettingsPage;

namespace firstlessen.Models.Pages
{
    [ContentType(
        GUID = "5CF56B7A-EB71-496E-A376-916296D19882",
        GroupName = Globals.GroupNames.Specialized
    )]
    [ImageUrl("/pages/CMS-icon-page-02.png")]
    [AvailableContentTypes(
        Availability.Specific,
        Include =
        [
            typeof(SettingsPage),
            typeof(ArticlePage),
            typeof(ContainerPage)

        ]
    )]

    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        [CultureSpecific]
        public virtual string Heading { get; set; } = string.Empty;
        [Display(
        GroupName = SystemTabNames.Content,
        Order = 20
         )]
        [CultureSpecific]
        public virtual required XhtmlString MainBody { get; set; }

		[Display(
			GroupName = SystemTabNames.Content,
			Order = 30,
            Name = "Slideshow",
			Description = "Add a slideshow to the page"
		)]
		[AllowedTypes(
            typeof(SlideshowPage),
            typeof(SlideshowPage)
            )]


        public virtual ContentArea Content { get; set; }
	}

	
}
