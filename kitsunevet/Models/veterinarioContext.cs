using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace kitsunevet.Models
{
    public partial class veterinarioContext : DbContext
    {
        public veterinarioContext()
        {
        }

        public veterinarioContext(DbContextOptions<veterinarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbBanhoTosa> TbBanhoTosa { get; set; }
        public virtual DbSet<TbCirurgia> TbCirurgia { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbExames> TbExames { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionario { get; set; }
        public virtual DbSet<TbHotel> TbHotel { get; set; }
        public virtual DbSet<TbLogin> TbLogin { get; set; }
        public virtual DbSet<TbPet> TbPet { get; set; }
        public virtual DbSet<TbVacinacao> TbVacinacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=1234;database=veterinario", x => x.ServerVersion("8.0.21-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbBanhoTosa>(entity =>
            {
                entity.HasKey(e => e.IdBanhoTosa)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.HasIndex(e => e.IdPet)
                    .HasName("id_pet");

                entity.Property(e => e.DsLocal)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsObservacoes)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbBanhoTosa)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_banho_tosa_ibfk_2");

                entity.HasOne(d => d.IdPetNavigation)
                    .WithMany(p => p.TbBanhoTosa)
                    .HasForeignKey(d => d.IdPet)
                    .HasConstraintName("tb_banho_tosa_ibfk_1");
            });

            modelBuilder.Entity<TbCirurgia>(entity =>
            {
                entity.HasKey(e => e.IdCirurgia)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.HasIndex(e => e.IdPet)
                    .HasName("id_pet");

                entity.Property(e => e.DsCirurgia)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsLocal)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsObservacoes)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCirurgia)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_cirurgia_ibfk_2");

                entity.HasOne(d => d.IdPetNavigation)
                    .WithMany(p => p.TbCirurgia)
                    .HasForeignKey(d => d.IdPet)
                    .HasConstraintName("tb_cirurgia_ibfk_1");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdLogin)
                    .HasName("id_login");

                entity.Property(e => e.DsCep)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsComplemento)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSexo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmCliente)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.TbCliente)
                    .HasForeignKey(d => d.IdLogin)
                    .HasConstraintName("tb_cliente_ibfk_1");
            });

            modelBuilder.Entity<TbExames>(entity =>
            {
                entity.HasKey(e => e.IdExames)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("Id_cliente");

                entity.HasIndex(e => e.IdPet)
                    .HasName("id_pet");

                entity.Property(e => e.DsExame)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsLocal)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsObservacoes)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbExames)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_exames_ibfk_2");

                entity.HasOne(d => d.IdPetNavigation)
                    .WithMany(p => p.TbExames)
                    .HasForeignKey(d => d.IdPet)
                    .HasConstraintName("tb_exames_ibfk_1");
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdLogin)
                    .HasName("id_login");

                entity.Property(e => e.DsEmailpessoal)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmFuncionario)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.TbFuncionario)
                    .HasForeignKey(d => d.IdLogin)
                    .HasConstraintName("tb_funcionario_ibfk_1");
            });

            modelBuilder.Entity<TbHotel>(entity =>
            {
                entity.HasKey(e => e.IdHotel)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.HasIndex(e => e.IdPet)
                    .HasName("id_pet");

                entity.Property(e => e.DsLocal)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsObservacoes)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbHotel)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_hotel_ibfk_2");

                entity.HasOne(d => d.IdPetNavigation)
                    .WithMany(p => p.TbHotel)
                    .HasForeignKey(d => d.IdPet)
                    .HasConstraintName("tb_hotel_ibfk_1");
            });

            modelBuilder.Entity<TbLogin>(entity =>
            {
                entity.HasKey(e => e.IdLogin)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbPet>(entity =>
            {
                entity.HasKey(e => e.IdPet)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.Property(e => e.DsMedicamentos)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsPorte)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsRaca)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSexo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmPet)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TpPet)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPet)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_pet_ibfk_1");
            });

            modelBuilder.Entity<TbVacinacao>(entity =>
            {
                entity.HasKey(e => e.IdVacinacao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.HasIndex(e => e.IdPet)
                    .HasName("id_pet");

                entity.Property(e => e.DsLocal)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsObservacoes)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsVacina)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbVacinacao)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_vacinacao_ibfk_2");

                entity.HasOne(d => d.IdPetNavigation)
                    .WithMany(p => p.TbVacinacao)
                    .HasForeignKey(d => d.IdPet)
                    .HasConstraintName("tb_vacinacao_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
