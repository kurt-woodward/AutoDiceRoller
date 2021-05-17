using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AutoDiceRoller.Models
{
    public partial class DiceRollerDBContext : DbContext
    {
        public DiceRollerDBContext()
        {
        }

        public DiceRollerDBContext(DbContextOptions<DiceRollerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OcrResult> OcrResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:LocalDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<OcrResult>(entity =>
            {
                entity.HasKey(e => e.RollId)
                    .HasName("PK__OCR_Resu__7886EE5F85E62DD5");

                entity.ToTable("OCR_Results");

                entity.Property(e => e.RollId).ValueGeneratedNever();

                entity.Property(e => e.ConfidenceLvl).HasColumnName("Confidence_Lvl");

                entity.Property(e => e.FaceValue).HasColumnName("Face_Value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
