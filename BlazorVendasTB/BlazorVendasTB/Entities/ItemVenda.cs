using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorVendasTB.Entities
{
    [Table("tbItemVenda")]
    public class ItemVenda
    {
        [Key]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int VendaId { get; set; }
        public Pedido pedido { get; set; }
        public int QuantidadeProduto { get; set; }
        public Double PrecoUnitario { get; set; }
    }
}