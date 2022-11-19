using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PagedList;
using Dto.Clima;
using Business.Implementation;
using Common;

namespace Clima.Controllers
{
    
    public class PronosticoController : Controller
    {

        PronosticoBusiness pronosticoBusiness = new PronosticoBusiness();
        CiudadBusiness ciudadBusiness = new CiudadBusiness();
        DepartamentoBusiness departamentoBusiness = new DepartamentoBusiness();
        [Authorize]
        // GET: clima
        public ActionResult Index(int? page)
        {
            PageList viewModel = new PageList();
            var pronostico = pronosticoBusiness.Consultar().Result;
            int currentPage = (page ?? 1);
            viewModel.pronosticos = pronostico.ToPagedList(currentPage, Constants.PageItems);
            return View(viewModel);
        }
        [Authorize]
        // GET: clima/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pronostico = pronosticoBusiness.ConsultarPronosticoPorId(id).Result.ToList();           
            if (pronostico == null)
            {
                return HttpNotFound();
            }
            return View(pronostico[0]);
        }
        [Authorize]
        // GET: clima/Create
        public ActionResult Create()
        {
            ViewBag.departamento_id = new SelectList(departamentoBusiness.Consultar().Result, "id", "nombre");
            ViewBag.municipio_id = new SelectList(new List<DepartamentoDto>(), "id", "nombre");
            return View();
        }

        [Authorize]
        // GET: clima/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pronostico = pronosticoBusiness.ConsultarPronosticoPorId(id).Result.ToList();
            if (pronostico.Count() == 0)
            {
                return HttpNotFound();
            }
           List<CiudadDto> lCiudad = new List<CiudadDto>();
            lCiudad.Add(pronostico[0].Ciudad);
            ViewBag.departamento_id = new SelectList(departamentoBusiness.Consultar().Result, "id", "nombre", pronostico[0].Ciudad.departamento_id);
            ViewBag.municipio_id = new SelectList(lCiudad, "id", "nombre", pronostico[0].Ciudad.id);

            return View(pronostico[0]);
        }

        // POST: clima/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,descripcion,municipio_id,departamento_id,fecha")] PronosticoDto pronostico)
        {
            if (ModelState.IsValid)
            {
                pronosticoBusiness.Guardar(pronostico);               
                return RedirectToAction("Index");
            }
            ViewBag.departamento_id = new SelectList(departamentoBusiness.Consultar().Result, "id", "nombre", pronostico.departamento_id);
            ViewBag.municipio_id = new SelectList(ciudadBusiness.Consultar().Result, "id", "nombre", pronostico.municipio_id);
            return View(pronostico);
        }
        // POST: clima/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,descripcion,municipio_id,departamento_id,fecha")] PronosticoDto pronostico)
        {
            if (ModelState.IsValid)
            {
                pronosticoBusiness.Actualizar(pronostico);               
                return RedirectToAction("Index");
            }
            ViewBag.departamento_id = new SelectList(departamentoBusiness.Consultar().Result, "id", "nombre", pronostico.departamento_id);
            ViewBag.municipio_id = new SelectList(ciudadBusiness.Consultar().Result, "id", "nombre", pronostico.municipio_id);
            return View(pronostico);
        }

        // GET: clima/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pronostico = pronosticoBusiness.ConsultarPronosticoPorId((int)id).Result.ToList();         
            if (pronostico == null)
            {
                return HttpNotFound();
            }
            return View(pronostico[0]);
        }

        // POST: clima/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pronosticoBusiness.Eliminar(id);          
            return RedirectToAction("Index");
        }
        [HttpPost]
        public JsonResult ListaCiudades(long IdDepartamento)
        {       
            var lCiudad = from c in ciudadBusiness.ConsultarCuidadPorId(IdDepartamento).Result select new { c.id, c.nombre };

            return Json(lCiudad, JsonRequestBehavior.AllowGet);
        }     
    }
}
