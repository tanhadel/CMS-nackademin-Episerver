using firstlessen.Models.Pages;
using System.ComponentModel.DataAnnotations;
using static firstlessen.Globals;

namespace firstlessen.Models.Block
{
    [ContentType(
        GUID = "64F0C968-8A9F-47C4-92BC-BC475172CB47",
        GroupName = GroupNames.Specialized,
        DisplayName =  "Slidshow",
        Description = "This is a slideshow block template"
    )]
    [ImageUrl("/pages/CMS-icon-page-02.png")]
    public class SlideshowBlock : BlockData
    {
        [Display(
          GroupName = SystemTabNames.Content,
            Order =10

         )]
        [AllowedTypes( typeof( SlideshowPage) 
         )]
        public virtual ContentArea Slideshow { get; set; }
    }
}
