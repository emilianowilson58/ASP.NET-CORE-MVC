namespace SistemaWebParaVendasOnline.Models
{
    public class UsuarioPermissao
    {

        //Relação entre a tabela Usuario e Permissao de [n:n] muitos para muitos
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
         
        public int PermissaoId { get; set; }
        public Permissao? Permissao { get; set; }
    }
}
