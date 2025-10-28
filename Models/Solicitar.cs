using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Projeto_Modelo_Manha.Models
{
    public class Solicitar
    {
        [Key]
        public int idSolicitar {  get; set; }
        [Required(ErrorMessage = "É obrigatório preencher o campo solicitante")]
        public string Solicitante {  get; set; }
        [Required(ErrorMessage = "É obrigatório preencher o campo Local")]
        public string localSolicitar { get; set; }
        [Required(ErrorMessage = "É obrigatório preencher o campo data")]
        public DateTime dataSolicitar { get; set; }
        [Required(ErrorMessage = "É obrigatório preencher o campo tipo")]
        public string Tipo {  get; set; }
        [Required(ErrorMessage = "É obrigatório preencher o campo descrição")]
        public string descricao {  get; set; }
    }
}
