namespace SistemaWebParaVendasOnline.Models
{
    public class ImagemProdutoModel
    {  //Criando relação com a tabela Produto de [n:1] muito para um
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string? CaminhoImagem { get; set; }
        public ProdutoModel? Produto { get; set; }
    }
}
