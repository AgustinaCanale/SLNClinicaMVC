using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCClinica.Data;
using MVCClinica.Models;
using System.Linq;

namespace MVCClinica.Controllers
{


    public class MedicoController : Controller
    {
        private readonly DBClinicaMVCContext context;

        public MedicoController(DBClinicaMVCContext context)
        {
            this.context = context;

        }

        //´métodos privados
        private Medico TraerUno(int id)
        {
            return context.Medicos.Find(id);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var medicos = context.Medicos.ToList();
            return View("Index", medicos);
        }


        //Create

        [HttpGet]
        public ActionResult Create()
        {

            Medico medico = new Medico();

            return View("Create", medico);

        }


        [HttpPost]
        public ActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }


        //Delete

        [HttpGet]


        public ActionResult Delete(int id)
        {
            var medico = TraerUno(id);

            if (medico == null)
            {
                return NotFound();
            }

            else
            {
                return View(medico);
            }

        }


        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var medico = TraerUno(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                context.Medicos.Remove(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }



        //GetDetails (BYID)


        [HttpGet]
        public ActionResult Details(int id)
        {
            Medico medico = TraerUno(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("detalle", medico);
            }

        }

        //Edit

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var medico = TraerUno(id);

            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View(medico);
            }
        }

        [HttpPost]
        [ActionName("Edit")]

        public ActionResult EditConfirmed(Medico medico) 
        {
            if (ModelState.IsValid)
            {
                context.Entry(medico).State = EntityState.Modified;

                context.SaveChanges();

                return RedirectToAction("Index");

            }
            else
            {
                return View(medico);
            }
        }



    }
}
