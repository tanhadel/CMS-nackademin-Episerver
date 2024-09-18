using System.ComponentModel.DataAnnotations;

namespace firstlessen.Models.Pages
{
    [ContentType(
        GUID = "5CF56B7A-EB71-496E-A376-916296D19882",
        GroupName = Globals.GroupNames.Specialized
    )]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        [CultureSpecific]
        public virtual string Heading { get; set; } = string.Empty;
    }
}
