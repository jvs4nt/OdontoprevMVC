using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdontoprevApi.Models
{
    [Table("tb_procedimento")]
    public class Procedimento
    {
        [Key]
        [Column("id_proc")]
        public string Id { get; set; }
        
        [Column("nm_proc")]
        public string Nome { get; set; }
        
        [Column("tp_proc")]
        public string Tipo { get; set; }
        
        [Column("custo_medio")]
        public decimal CustoMedio { get; set; }
        
        [Column("complexidade")]
        public string Complexidade { get; set; }
    }
}