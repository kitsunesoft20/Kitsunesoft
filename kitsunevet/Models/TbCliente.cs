using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_cliente")]
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbBanhoTosa = new HashSet<TbBanhoTosa>();
            TbCirurgia = new HashSet<TbCirurgia>();
            TbExames = new HashSet<TbExames>();
            TbHotel = new HashSet<TbHotel>();
            TbPet = new HashSet<TbPet>();
            TbVacinacao = new HashSet<TbVacinacao>();
        }

        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("id_login")]
        public int? IdLogin { get; set; }
        [Column("nm_cliente", TypeName = "varchar(100)")]
        public string NmCliente { get; set; }
        [Column("ds_sexo", TypeName = "varchar(50)")]
        public string DsSexo { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime? DtNascimento { get; set; }
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Column("ds_telefone", TypeName = "varchar(50)")]
        public string DsTelefone { get; set; }
        [Column("ds_cpf", TypeName = "varchar(50)")]
        public string DsCpf { get; set; }
        [Column("ds_rg", TypeName = "varchar(50)")]
        public string DsRg { get; set; }
        [Column("ds_endereco", TypeName = "varchar(100)")]
        public string DsEndereco { get; set; }
        [Column("ds_complemento", TypeName = "varchar(100)")]
        public string DsComplemento { get; set; }
        [Column("ds_cep", TypeName = "varchar(50)")]
        public string DsCep { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbCliente))]
        public virtual TbLogin IdLoginNavigation { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbBanhoTosa> TbBanhoTosa { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbCirurgia> TbCirurgia { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbExames> TbExames { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbHotel> TbHotel { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbPet> TbPet { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbVacinacao> TbVacinacao { get; set; }
    }
}
