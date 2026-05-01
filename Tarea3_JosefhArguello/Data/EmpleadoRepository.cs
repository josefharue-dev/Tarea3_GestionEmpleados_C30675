using Tarea3_JosefhArguello.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarea3_JosefhArguello.Data
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly AppDbContext _context;

        public EmpleadoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Empleado> ObtenerTodos()
        {
            return _context.Empleados.ToList();
        }

        public Empleado ObtenerPorId(int id)
        {
            return _context.Empleados.FirstOrDefault(e => e.Id == id);
        }

        public List<Empleado> Buscar(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
                return _context.Empleados.ToList();

            busqueda = busqueda.ToLower();

            return _context.Empleados
                .Where(e =>
                    e.Nombre.ToLower().Contains(busqueda) ||
                    e.Apellidos.ToLower().Contains(busqueda) ||
                    e.Departamento.ToLower().Contains(busqueda))
                .ToList();
        }

        public List<Empleado> ObtenerPaginado(string busqueda, int pagina, int tamanoPagina)
        {
            var query = _context.Empleados.AsQueryable();

            if (!string.IsNullOrEmpty(busqueda))
            {
                busqueda = busqueda.ToLower();

                query = query.Where(e =>
                    e.Nombre.ToLower().Contains(busqueda) ||
                    e.Apellidos.ToLower().Contains(busqueda) ||
                    e.Departamento.ToLower().Contains(busqueda));
            }

            return query
                .Skip((pagina - 1) * tamanoPagina)
                .Take(tamanoPagina)
                .ToList();
        }

        public int Contar(string busqueda)
        {
            var query = _context.Empleados.AsQueryable();

            if (!string.IsNullOrEmpty(busqueda))
            {
                busqueda = busqueda.ToLower();

                query = query.Where(e =>
                    e.Nombre.ToLower().Contains(busqueda) ||
                    e.Apellidos.ToLower().Contains(busqueda) ||
                    e.Departamento.ToLower().Contains(busqueda));
            }

            return query.Count();
        }

        public void Agregar(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        public void Actualizar(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
            _context.SaveChanges();
        }
    }
}
