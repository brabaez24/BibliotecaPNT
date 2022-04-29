using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaBB.Datos.modelo
{
    public class Estudiante
    {
        [Key]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Programa { get; set; }
        public int Semestre { get; set; }
    }
}
