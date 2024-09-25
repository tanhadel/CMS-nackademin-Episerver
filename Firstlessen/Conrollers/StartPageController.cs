using firstlessen.Models.Pages;
using firstlessen.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace firstlessen.Conrollers
{

    public class StartPageController : PageControllerBase<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}
