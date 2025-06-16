namespace AulaApiDevOpsManhaPiaget.Models
{
    public class Fornecedor : Base
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public int ProdutosId { get; set; }
    }
}
