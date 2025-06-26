using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorVendasTB.Entities
{
    [Table("tbFuncionario")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        private string Cpf { get; set; }
        private string Email { get; set; }
        private string Cargo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
