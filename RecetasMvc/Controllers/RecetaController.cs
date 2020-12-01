using RecetaSpawn.Domain.Service;
using System.Web.Mvc;

namespace RecetasMvc.Controllers
{
    public class RecetaController : Controller
    {
        // = Seria comparar numeros 7 = 7;
        // == Seria para cualquier cosas que no sea valor, 'Texto' == 'Texto' || VAlor == null;
        // GET: Receta
        TblRecetaCTRL Receta = new TblRecetaCTRL();
        [HttpGet]
        public ActionResult RecetasEdit(int id=0)
        {
            //Receta receta1 = new Receta();
            return View();
        }

        public ActionResult Ver()
        {
            ViewBag.RecetaList = Receta.TraerReceta();
            return View();
        }



    }
}