using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_hotel")]
    public partial class TbHotel
    {
        [Key]
        [Column("id_hotel")]
        public int IdHotel { get; set; }
        [Column("id_cliente")]
        public int? IdCliente { get; set; }
        [Column("id_pet")]
        public int? IdPet { get; set; }
        [Column("ds_delivery")]
        public bool? DsDelivery { get; set; }
        [Column("dt_entrada", TypeName = "datetime")]
        public DateTime? DtEntrada { get; set; }
        [Column("dt_saida", TypeName = "datetime")]
        public DateTime? DtSaida { get; set; }
        [Column("ds_local", TypeName = "varchar(100)")]
        public string DsLocal { get; set; }
        [Column("ds_observacoes", TypeName = "varchar(255)")]
        public string DsObservacoes { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbHotel))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdPet))]
        [InverseProperty(nameof(TbPet.TbHotel))]
        public virtual TbPet IdPetNavigation { get; set; }
    }
}
