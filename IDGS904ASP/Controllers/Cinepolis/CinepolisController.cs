using introCsharp.Models;
using System.Web.Mvc;

namespace introCsharp.Controllers
{
    public class CinepolisController : Controller
    {
        public ActionResult Cinepolis()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cinepolis(Cinepolis cine)
        {
            int maxBoletos = cine.Compradores * 7;

            if (cine.Boletos > maxBoletos)
            {
                cine.Mensaje = "No puedes comprar esa cantidad de boletos";
                cine.Total = 0;

                return View(cine);
            }

            double subtotal = cine.Boletos * 12;

            if (cine.Boletos > 5)
            {
                subtotal = subtotal - (subtotal * 0.15);
            }
            else if (cine.Boletos >= 3 && cine.Boletos <= 5)
            {
                subtotal = subtotal - (subtotal * 0.10);
            }

            if (cine.Tarjeta == "si")
            {
                subtotal = subtotal - (subtotal * 0.10);
            }

            cine.Total = subtotal;
            cine.Mensaje = "Compra realizada";

            return View(cine);
        }
    }
}