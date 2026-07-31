namespace SistemaWebParaVendasOnline.Models
{
    public class PedidoModel
    {      //Criando relação com a tabela usuario de [n:1] muito para um
        public int Id { get; set; }
        public int CompradorId { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public string? Status { get; set; }
        public UsuarioModel? Comprador { get; set; }
       
    }
}
