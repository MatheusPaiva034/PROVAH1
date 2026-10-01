using System.ComponentModel.DataAnnotations;
namespace PovaH1.Models
{
    public class Eleitores
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; } = string.Empty;


        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(50)]
        public string TituloEleitor { get; set; }

        
        [Required]
        [StringLength(2)]
        public string UF { get; set; } = string.Empty;

       

    }
}
