using Microsoft.AspNetCore.Mvc;
using Model;

namespace BuscadorCEP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Address()
        {
            var model = new AddressCEP();

            model.Titulo = "";

            return View();
        }

        public ActionResult CEP()
        {
            var model = new AddressCEP();

            model.Titulo = "Buscar Endereço";

            return View(model);
        }

        public ActionResult Buscar(AddressCEP addressCEP)
        {
            var model = new AddressCEP();

            return View(model);
        }
    }
}