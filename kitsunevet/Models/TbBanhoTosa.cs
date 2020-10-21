using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_banho_tosa")]
    public partial class TbBanhoTosa
    {
        [Key]
        [Column("id_banho_tosa")]
        public int IdBanhoTosa { get; set; }
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("id_pet")]
        public int IdPet { get; set; }
        [Column("ds_banho")]
        public bool DsBanho { get; set; }
        [Column("ds_tosa")]
        public bool DsTosa { get; set; }
        [Column("ds_unhas")]
        public bool DsUnhas { get; set; }
        [Column("ds_dentes")]
        public bool DsDentes { get; set; }
        [Column("dt_banho_tosa", TypeName = "datetime")]
        public DateTime DtBanhoTosa { get; set; }
        [Required]
        [Column("ds_local", TypeName = "varchar(100)")]
        public string DsLocal { get; set; }
        [Column("ds_observacoes", TypeName = "varchar(255)")]
        public string DsObservacoes { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbBanhoTosa))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdPet))]
        [InverseProperty(nameof(TbPet.TbBanhoTosa))]
        public virtual TbPet IdPetNavigation { get; set; }
    }
}
