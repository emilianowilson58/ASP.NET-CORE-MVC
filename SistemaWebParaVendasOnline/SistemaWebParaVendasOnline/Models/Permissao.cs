namespace SistemaWebParaVendasOnline.Models
{
    public class Permissao
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        //Criando relação com as Permissões
        public ICollection<UsuarioPermissao>? UsuarioPermissaos { get; set; }
    }
}
