using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        int hour = DateTime.Now.Hour;
        string viewModel = hour < 12 ? "good morning" : "good afternoon";
        return View("MyView", viewModel);
    }
}
