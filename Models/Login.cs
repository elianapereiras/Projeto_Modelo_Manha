using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Projeto_Modelo_Manha.Models
{
    public class Login
    {
        [Key]
        public int idLogin { get; set; }

        [Required(ErrorMessage ="É obrigatório preencher o campo nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o campo email")]
        [EmailAddress(ErrorMessage ="Digite um email válido")]
        public string email { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o campo senha")]
        [MaxLength(8,ErrorMessage = "É obrigatório preencher o campo nome")]
        public string senha { get; set; }
    }
}
