namespace SistemaWebParaVendasOnline.Models
{
    public class ItemPedidoModel
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        //Relação entre as tabela Pedido e Produto de [n:n] muitos para muitos
        public int PedidoId { get; set; }
        public PedidoModel? Pedido { get; set; }

        public int ProdutoId { get; set; }
        public ProdutoModel? Produto { get; set; }

        
    }
}
