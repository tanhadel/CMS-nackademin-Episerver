using EPiServer.Web.Mvc;
using firstlessen.Models.Pages;

namespace firstlessen.Conrollers
{
    public abstract class PageControllerBase <T> : PageController<T> where T : SitePageData
    {

    }
}
