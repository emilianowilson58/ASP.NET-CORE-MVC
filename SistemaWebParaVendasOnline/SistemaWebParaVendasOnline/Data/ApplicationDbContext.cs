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
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<MensagemModel> Mensagens { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<CarrinhoModel> Carrinhos { get; set; }
        public DbSet<ImagemProdutoModel> ImagemProdutos { get; set; }
        public DbSet<ItemCarrinhoModel> ItemCarrinhos { get; set; }
        //public DbSet<ItemPedidoModel> ItemPedidos { get; set; }
        public DbSet<PedidoModel> Pedidos { get; set; }
        public DbSet<PermissaoModel> Permissaos { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<UsuarioPermissaoModel> UsuarioPermissaos { get; set; }

        //Explicando ao Entity framework o tipo de relação para não houver comflito sabendo que estou a usar duas chaves da mesma propriedade

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MensagemModel>().HasOne(m => m.Usuario).WithMany().HasForeignKey(m => m.RemetenteId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MensagemModel>().HasOne(m => m.Destinatario).WithMany().HasForeignKey(m => m.DestinatarioId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
