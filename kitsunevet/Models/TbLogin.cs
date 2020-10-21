using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_login")]
    public partial class TbLogin
    {
        public TbLogin()
        {
            TbCliente = new HashSet<TbCliente>();
            TbFuncionario = new HashSet<TbFuncionario>();
        }

        [Key]
        [Column("id_login")]
        public int IdLogin { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_senha", TypeName = "varchar(100)")]
        public string DsSenha { get; set; }

        [InverseProperty("IdLoginNavigation")]
        public virtual ICollection<TbCliente> TbCliente { get; set; }
        [InverseProperty("IdLoginNavigation")]
        public virtual ICollection<TbFuncionario> TbFuncionario { get; set; }
    }
}
