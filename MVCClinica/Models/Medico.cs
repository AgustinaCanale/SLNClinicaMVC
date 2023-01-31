using System.ComponentModel.DataAnnotations;

namespace MVCClinica.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [RegularExpression("[a-zA-Z]{2}[1-9]{4}$")]
        public string Matricula { get; set; }
    }
}
