namespace SistemaWebParaVendasOnline.ViewModel
{
    public class CheckoutViewModel
    {
        //Dados Necessários da tela de Fechamento
        public decimal Total { get; set; }
        public string? Morada { get; set; }
        public string? Telefone { get; set; }
        public string? MetodoPagamento { get; set; }
    }
}
