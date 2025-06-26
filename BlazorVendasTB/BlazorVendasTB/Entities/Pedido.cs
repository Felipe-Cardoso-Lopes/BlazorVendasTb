namespace BlazorVendasTB.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int FuncionarioId { get; set; }
        public int Funcionario { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Double ValorTotal { get; set; }
        public ICollection<ItemVenda> ItemVendas { get; set; }
    }
}
