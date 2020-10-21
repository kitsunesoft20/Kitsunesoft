using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitsunevet.Models
{
    [Table("tb_pet")]
    public partial class TbPet
    {
        public TbPet()
        {
            TbBanhoTosa = new HashSet<TbBanhoTosa>();
            TbCirurgia = new HashSet<TbCirurgia>();
            TbExames = new HashSet<TbExames>();
            TbHotel = new HashSet<TbHotel>();
            TbVacinacao = new HashSet<TbVacinacao>();
        }

        [Key]
        [Column("id_pet")]
        public int IdPet { get; set; }
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("tp_pet", TypeName = "varchar(50)")]
        public string TpPet { get; set; }
        [Required]
        [Column("nm_pet", TypeName = "varchar(100)")]
        public string NmPet { get; set; }
        [Required]
        [Column("ds_sexo", TypeName = "varchar(50)")]
        public string DsSexo { get; set; }
        [Required]
        [Column("ds_raca", TypeName = "varchar(100)")]
        public string DsRaca { get; set; }
        [Required]
        [Column("ds_porte", TypeName = "varchar(50)")]
        public string DsPorte { get; set; }
        [Required]
        [Column("ds_medicamentos", TypeName = "varchar(255)")]
        public string DsMedicamentos { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime DtNascimento { get; set; }
        [Column("ds_peso", TypeName = "decimal(10,0)")]
        public decimal DsPeso { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbPet))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [InverseProperty("IdPetNavigation")]
        public virtual ICollection<TbBanhoTosa> TbBanhoTosa { get; set; }
        [InverseProperty("IdPetNavigation")]
        public virtual ICollection<TbCirurgia> TbCirurgia { get; set; }
        [InverseProperty("IdPetNavigation")]
        public virtual ICollection<TbExames> TbExames { get; set; }
        [InverseProperty("IdPetNavigation")]
        public virtual ICollection<TbHotel> TbHotel { get; set; }
        [InverseProperty("IdPetNavigation")]
        public virtual ICollection<TbVacinacao> TbVacinacao { get; set; }
    }
}
