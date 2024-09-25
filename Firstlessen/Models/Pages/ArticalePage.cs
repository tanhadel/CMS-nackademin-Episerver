using static firstlessen.Globals;
using System.ComponentModel.DataAnnotations;

namespace firstlessen.Models.Pages
{
    [ContentType(
         GUID = "EE45BF6A-8F77-4D05-8950-4753C0CABBF7",
         GroupName = GroupNames.Specialized
     )]
    [ImageUrl("/pages/CMS-icon-page-02.png")]

    public class ArticlePage : SitePageData
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
        public virtual XhtmlString MainBody { get; set; }
    }
}
