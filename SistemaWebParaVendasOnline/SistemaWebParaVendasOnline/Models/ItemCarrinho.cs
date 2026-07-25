namespace SistemaWebParaVendasOnline.Models
{
    public class ItemCarrinho
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }

        //Relação entre a tabela Carrinho e Produto de [n:n] muitos para muitos
        public int CarrimhoId { get; set; }
        public Carrinho? Carrinho { get; set; }
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
