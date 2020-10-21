using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_exames")]
    public partial class TbExames
    {
        [Key]
        [Column("id_exames")]
        public int IdExames { get; set; }
        [Column("Id_cliente")]
        public int IdCliente { get; set; }
        [Column("id_pet")]
        public int IdPet { get; set; }
        [Required]
        [Column("ds_exame", TypeName = "varchar(100)")]
        public string DsExame { get; set; }
        [Column("dt_exame", TypeName = "datetime")]
        public DateTime DtExame { get; set; }
        [Required]
        [Column("ds_local", TypeName = "varchar(100)")]
        public string DsLocal { get; set; }
        [Column("ds_observacoes", TypeName = "varchar(255)")]
        public string DsObservacoes { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbExames))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdPet))]
        [InverseProperty(nameof(TbPet.TbExames))]
        public virtual TbPet IdPetNavigation { get; set; }
    }
}
