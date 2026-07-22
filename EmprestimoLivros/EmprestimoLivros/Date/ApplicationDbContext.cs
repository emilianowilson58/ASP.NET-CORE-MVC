using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EmprestimoLivros.Date
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Class connection 
            // DbContextOptions<ApplicationDbContext> options -> vai enviar ao Entity framework as configurações necessaria para se comunicar ao Banco
            //Esses configurações vão vir da class Program
            // base(options) está a passar todas as informações para o Entity framework
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }  //Criando a tabela no banco com as informações do Model
    }
    
}
//Essa classe é uma instância do banco de dados