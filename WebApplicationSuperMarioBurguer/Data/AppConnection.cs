using Microsoft.EntityFrameworkCore;
using WebApplicationSuperMarioBurguer.Models;

namespace WebApplicationSuperMarioBurguer.Data
{
    public class AppConnection : DbContext
    {
        //Construtor
        public AppConnection(DbContextOptions<AppConnection> options) : base(options) 
        { 
        }
        //Criando a tabela
        public DbSet<FornecedorModel> Fornecedores { get; set; }
    }
}
