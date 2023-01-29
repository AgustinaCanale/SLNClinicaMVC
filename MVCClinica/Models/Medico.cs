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

        [RegularExpression("@([A]{2})+([1-9]{4})")]
        public int Matricula { get; set; }
    }
}
