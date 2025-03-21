using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdontoprevApi.Models
{
    [Table("tb_cliente")]
    public class Cliente
    {
        [Key]
        [Column("id_clie")]
        public string Id { get; set; }
        
        [Column("cpf")]
        public string Cpf { get; set; }
        
        [Column("dt_cadastro")]
        public DateTime DataCadastro { get; set; }
        
        [Column("nm_clie")]
        public string Nome { get; set; }
        
        [Column("dt_nasc")]
        public DateTime DataNascimento { get; set; }
        
        [Column("genero")]
        public string Genero { get; set; }
        
        [Column("telefone")]
        public string Telefone { get; set; }
        
        [Column("email")]
        public string Email { get; set; }
        
        // Para simplificar, armazenamos os IDs de FK como string
        [Column("tb_endereco_id_end")]
        public string EnderecoId { get; set; }
        
        [Column("tb_plano_id_plano")]
        public string PlanoId { get; set; }
    }
}