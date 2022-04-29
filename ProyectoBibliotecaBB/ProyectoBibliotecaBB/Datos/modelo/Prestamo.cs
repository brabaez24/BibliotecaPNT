+using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaBB.Datos.modelo
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }
        public string NombreLibro { get; set; }
        public int IdEstudiante { get; set; }
        public int Fecha { get; set; }
        public int DiasPrestamo  { get; set; }
      
    }
}
