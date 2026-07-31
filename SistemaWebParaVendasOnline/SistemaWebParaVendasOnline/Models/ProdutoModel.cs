namespace SistemaWebParaVendasOnline.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataPublicacao { get; set; }

        //Para indicar o relacionamento. Quem publicou
        //Relação entre a tabela Usuario e Categoria de [n:n] muitos para muitos
        public int UsuarioId { get; set; }
        public UsuarioModel? Usuario { get; set; }

        public int CategoriaId { get; set; }
        public CategoriaModel? Categoria { get; set; }
    }
}
