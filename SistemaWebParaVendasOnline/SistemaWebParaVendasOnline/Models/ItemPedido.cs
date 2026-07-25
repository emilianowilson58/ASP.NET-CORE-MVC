namespace SistemaWebParaVendasOnline.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        //Relação entre as tabela Pedido e Produto de [n:n] muitos para muitos
        public int pedidoId { get; set; }
        public Pedido? Pedido { get; set; }

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
