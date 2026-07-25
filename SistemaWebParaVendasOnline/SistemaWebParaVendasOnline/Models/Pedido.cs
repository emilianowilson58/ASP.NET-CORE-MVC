namespace SistemaWebParaVendasOnline.Models
{
    public class Pedido
    {      //Criando relação com a tabela usuario de [n:1] muito para um
        public int Id { get; set; }
        public int CompradorId { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public string? Status { get; set; }
        public Usuario? Comprador { get; set; }
    }
}
