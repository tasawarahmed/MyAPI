using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyAPI.Models
{
    public partial class SchoolDBV2Context : DbContext
    {
        public SchoolDBV2Context()
        {
        }

        public SchoolDBV2Context(DbContextOptions<SchoolDBV2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Complaint> Complaints { get; set; } = null!;
        public virtual DbSet<Gallery> Galleries { get; set; } = null!;
        public virtual DbSet<ParentsMessage> ParentsMessages { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=SchoolDBV2;Integrated Security=True; Max Pool Size = 100;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsReplied).HasColumnName("isReplied");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Reply).HasColumnName("reply");

                entity.Property(e => e.StuId).HasColumnName("stuID");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Event).HasColumnName("event");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Link).HasColumnName("link");

                entity.Property(e => e.Remarks).HasColumnName("remarks");
            });

            modelBuilder.Entity<ParentsMessage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsReplied).HasColumnName("isReplied");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Reply).HasColumnName("reply");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
