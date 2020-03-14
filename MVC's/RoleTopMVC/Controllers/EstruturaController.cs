using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class EstruturaController : Controller
    {
        public IActionResult planta()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Estrutura"
            });
        }
    }
}