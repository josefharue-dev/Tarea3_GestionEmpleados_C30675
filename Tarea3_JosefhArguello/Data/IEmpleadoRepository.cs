using Tarea3_JosefhArguello.Models;

namespace Tarea3_JosefhArguello.Data
{
    public interface IEmpleadoRepository
    {
        List<Empleado> ObtenerTodos();
        Empleado ObtenerPorId(int id);

        List<Empleado> Buscar(string busqueda);

        List<Empleado> ObtenerPaginado(string busqueda, int pagina, int tamanoPagina);

        int Contar(string busqueda);

        void Agregar(Empleado empleado);
        void Actualizar(Empleado empleado);
    }
}
