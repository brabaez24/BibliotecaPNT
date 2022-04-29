using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaBB.Datos.modelo
{
    public class Autor
    {
        [Key]
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string  AKA { get; set; }
        public int AñoPublicacion { get; set; }
    }
}
