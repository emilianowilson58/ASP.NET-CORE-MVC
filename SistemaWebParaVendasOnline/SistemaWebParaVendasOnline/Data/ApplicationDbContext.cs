using Microsoft.EntityFrameworkCore;
using SistemaWebParaVendasOnline.Models;

namespace SistemaWebParaVendasOnline.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Criando as tabelas 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }

        //Explicando ao Entity framework o tipo de relação para não houver comflito sabendo que estou a usar duas chaves da mesma propriedade

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Mensagem>().HasOne(m => m.Usuario).WithMany().HasForeignKey(m => m.RemetenteId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Mensagem>().HasOne(m => m.Destinatario).WithMany().HasForeignKey(m => m.DestinatarioId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
