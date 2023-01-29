using System.ComponentModel.DataAnnotations;

namespace MVCClinica.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }
        public int Matricula { get; set; }
    }
}
