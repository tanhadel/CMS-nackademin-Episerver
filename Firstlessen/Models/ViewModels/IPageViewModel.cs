using firstlessen.Models.Pages;

namespace firstlessen.Models.ViewModels
{
    public interface IPageViewModel <out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
    }
}
