using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FDS_SITE.Models
{
    public partial class FDSContext : DbContext
    {
        public virtual DbSet<Cuestionario> Cuestionario { get; set; }
        public virtual DbSet<DetalleCuestionario> DetalleCuestionario { get; set; }
        public virtual DbSet<Quejas> Quejas { get; set; }
        public virtual DbSet<RespuestaCuestionario> RespuestaCuestionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DD3LKCK\MSSQLSOFIA;Initial Catalog=FDS;user=sa;Password=sofia;Persist Security Info=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuestionario>(entity =>
            {
                entity.HasKey(e => e.CodigoCuestionario);

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<DetalleCuestionario>(entity =>
            {
                entity.HasKey(e => e.Numero);

                entity.ToTable("Detalle_Cuestionario");

                entity.Property(e => e.Pregunta).HasMaxLength(200);

                entity.Property(e => e.TipoControl).HasMaxLength(100);
            });

            modelBuilder.Entity<Quejas>(entity =>
            {
                entity.HasKey(e => e.CodigoQueja);

                entity.Property(e => e.Empleado).HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Imagen).HasMaxLength(100);

                entity.Property(e => e.Queja).IsRequired();

                entity.Property(e => e.Ubicacion).HasMaxLength(100);
            });

            modelBuilder.Entity<RespuestaCuestionario>(entity =>
            {
                entity.HasKey(e => e.CodigoRespuesta);

                entity.ToTable("Respuesta_Cuestionario");

                entity.Property(e => e.RespBoolean).HasColumnName("Resp_Boolean");

                entity.Property(e => e.RespDatetime)
                    .HasColumnName("Resp_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RespInteger).HasColumnName("Resp_Integer");

                entity.Property(e => e.RespMoney)
                    .HasColumnName("Resp_Money")
                    .HasColumnType("money");

                entity.Property(e => e.RespString).HasColumnName("Resp_String");
            });
        }
    }
}
