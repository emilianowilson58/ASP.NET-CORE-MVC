namespace SistemaWebParaVendasOnline.Models
{
    public class ImagemProduto
    {  //Criando relação com a tabela Produto de [n:1] muito para um
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string? CaminhoImagem { get; set; }
        public Produto? Produto { get; set; }
    }
}
