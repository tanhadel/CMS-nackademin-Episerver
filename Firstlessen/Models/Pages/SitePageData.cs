using System.ComponentModel.DataAnnotations;

namespace firstlessen.Models.Pages
{
    public class SitePageData : PageData
    {
        [Display(
            GroupName = Globals.GroupNames.Metadata,
            Order = 100
            )]
        [CultureSpecific]

        public virtual string MetaTitle 
        { 
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);
                return string.IsNullOrWhiteSpace(metaTitle) ? metaTitle : PageName;
            }
            set => this.SetPropertyValue(p => p.MetaTitle, value);
        } 

    }
}
