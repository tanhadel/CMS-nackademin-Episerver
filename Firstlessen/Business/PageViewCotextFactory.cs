using EPiServer.ServiceLocation;
using EPiServer.Web;
using firstlessen.Models.Pages;
using firstlessen.Models.ViewModels;
using static firstlessen.Models.Pages.SettingsPage;

namespace firstlessen.Business
{
    [ServiceConfiguration]
    public class PageViewCotextFactory(IContentLoader contentLoader, ILogger<PageViewCotextFactory> logger)
    {
         private readonly IContentLoader _contentLoader = contentLoader;
         private readonly ILogger<PageViewCotextFactory> _logger = logger;

        public ILogger<PageViewCotextFactory> Logger { get; }

        public virtual LayoutModel CreatLaoutModel(ContentReference contentReference, HttpContext httpContext)
        {
            var startpageContentLink = SiteDefinition.Current.StartPage;
            if (contentReference.CompareToIgnoreWorkID(startpageContentLink))
            {
                startpageContentLink = contentReference;

            }
            var startPage = _contentLoader.Get<StartPage>(startpageContentLink);

            return new LayoutModel
            {
                StartPage = startPage,
                SettingsPage = GetSettingspage()
            };
        }
        private SettingsPage GetSettingspage()
        {
            if (SiteDefinition.Current.StartPage != ContentReference.EmptyReference)
            {
                var settingsPage = _contentLoader.GetChildren<SettingsPage>(SiteDefinition.Current.StartPage).FirstOrDefault();
                if (settingsPage != null)
                {
                    return settingsPage;
                }
                else
                {
                    //log
                    _logger.LogError("No settings page found");
                }

            }
            else
            {
                //log
                _logger.LogError("No start page found");
            }
            return null!;

        }
    }

}
