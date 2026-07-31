namespace SistemaWebParaVendasOnline.Models
{
    public class UsuarioPermissaoModel
    {

        //Relação entre a tabela Usuario e Permissao de [n:n] muitos para muitos
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public UsuarioModel? Usuario { get; set; }
         
        public int PermissaoId { get; set; }
        public PermissaoModel? Permissao { get; set; }
    }
}
