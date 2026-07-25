namespace SistemaWebParaVendasOnline.ViewModel
{
    public class ProdutoViewModel
    {
        //Dados Necessários da tela de Produtos
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int Categoria { get; set; }
        public string? Descricao { get; set; }
        //public List<Categoria> Categorias  { get; set; }
    }
}
