using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoFdevs.Models;

namespace ProjetoFdevs.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel homeModel = new HomeModel();

            homeModel.Nome = "Tal";
            homeModel.Email = "tal@gmail.com";

            return View(homeModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
