using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaBB.Datos.modelo;

namespace ProyectoBibliotecaBB.Datos.Servicio
{
    public class RepositorioBiblioteca : DbContext

    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca>options):base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }

    }
}
