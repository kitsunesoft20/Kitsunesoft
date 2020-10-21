using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_cirurgia")]
    public partial class TbCirurgia
    {
        [Key]
        [Column("id_cirurgia")]
        public int IdCirurgia { get; set; }
        [Column("id_pet")]
        public int IdPet { get; set; }
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("ds_cirurgia", TypeName = "varchar(100)")]
        public string DsCirurgia { get; set; }
        [Column("dt_cirurgia", TypeName = "datetime")]
        public DateTime DtCirurgia { get; set; }
        [Required]
        [Column("ds_local", TypeName = "varchar(100)")]
        public string DsLocal { get; set; }
        [Column("ds_observacoes", TypeName = "varchar(255)")]
        public string DsObservacoes { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbCirurgia))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdPet))]
        [InverseProperty(nameof(TbPet.TbCirurgia))]
        public virtual TbPet IdPetNavigation { get; set; }
    }
}
