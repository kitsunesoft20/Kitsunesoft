using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_funcionario")]
    public partial class TbFuncionario
    {
        [Key]
        [Column("id_funcionario")]
        public int IdFuncionario { get; set; }
        [Column("id_login")]
        public int? IdLogin { get; set; }
        [Column("nm_funcionario", TypeName = "varchar(100)")]
        public string NmFuncionario { get; set; }
        [Column("ds_emailpessoal", TypeName = "varchar(100)")]
        public string DsEmailpessoal { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbFuncionario))]
        public virtual TbLogin IdLoginNavigation { get; set; }
    }
}
