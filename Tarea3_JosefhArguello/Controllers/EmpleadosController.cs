using Microsoft.AspNetCore.Mvc;
using Tarea3_JosefhArguello.Data;
using Tarea3_JosefhArguello.Models;

namespace Tarea3_JosefhArguello.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadoRepository _repo;

        public EmpleadosController(IEmpleadoRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(string busqueda, int pagina = 1)
        {
            int tamanoPagina = 5;

            var empleados = _repo.ObtenerPaginado(busqueda, pagina, tamanoPagina);
            var total = _repo.Contar(busqueda);

            ViewBag.Busqueda = busqueda;
            ViewBag.PaginaActual = pagina;
            ViewBag.TotalPaginas = (int)Math.Ceiling((double)total / tamanoPagina);

            return View(empleados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            if (!ModelState.IsValid)
                return View(empleado);

            _repo.Agregar(empleado);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var empleado = _repo.ObtenerPorId(id);

            if (empleado == null)
                return NotFound();

            return View(empleado);
        }

        [HttpPost]
        public IActionResult Edit(Empleado empleado)
        {
            if (!ModelState.IsValid)
                return View(empleado);

            _repo.Actualizar(empleado);
            return RedirectToAction("Index");
        }

        public IActionResult ToggleActivo(int id)
        {
            var empleado = _repo.ObtenerPorId(id);

            if (empleado == null)
                return NotFound();

            empleado.Activo = !empleado.Activo;

            _repo.Actualizar(empleado);

            return RedirectToAction("Index");
        }
    }
}
