namespace SistemaWebParaVendasOnline.Models
{
    public class PermissaoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        //Criando relação com as Permissões
        public ICollection<UsuarioPermissaoModel>? UsuarioPermissaos { get; set; }
    }
}
