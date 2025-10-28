using Projeto_Modelo_Manha;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace Projeto_Modelo_Manha.Models
{
    public class Dados_DbContext: DbContext
    {
        public Dados_DbContext(DbContextOptions<Dados_DbContext> options) : base(options)
        {
        }

        public DbSet<Login> login {get; set; }
        public DbSet<Solicitar> solicitar { get; set; }
    }
    
}
