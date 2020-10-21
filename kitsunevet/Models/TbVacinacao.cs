using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_vacinacao")]
    public partial class TbVacinacao
    {
        [Key]
        [Column("id_vacinacao")]
        public int IdVacinacao { get; set; }
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("id_pet")]
        public int IdPet { get; set; }
        [Column("dt_vacinacao", TypeName = "datetime")]
        public DateTime DtVacinacao { get; set; }
        [Required]
        [Column("ds_vacina", TypeName = "varchar(100)")]
        public string DsVacina { get; set; }
        [Required]
        [Column("ds_local", TypeName = "varchar(100)")]
        public string DsLocal { get; set; }
        [Column("ds_observacoes", TypeName = "varchar(255)")]
        public string DsObservacoes { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbVacinacao))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdPet))]
        [InverseProperty(nameof(TbPet.TbVacinacao))]
        public virtual TbPet IdPetNavigation { get; set; }
    }
}
