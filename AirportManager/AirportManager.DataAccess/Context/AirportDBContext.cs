using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AirportManager.DataAccess.Models.DBModels;

#nullable disable

namespace AirportManager.DataAccess.Context
{
    public partial class AirportDBContext : DbContext
    {
        public AirportDBContext()
        {
        }

        public AirportDBContext(DbContextOptions<AirportDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AirportDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Airport>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Airports__737584F617FBB5AD")
                    .IsUnique();

                entity.HasIndex(e => e.Iata, "UQ__Airports__82F6AFF4C2E41A75")
                    .IsUnique();

                entity.Property(e => e.Iata)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("IATA");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Airports)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Airports__Countr__078C1F06");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Countrie__737584F69957101C")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.DestinationId)
                    .HasConstraintName("FK__Flights__Destina__18B6AB08");

                entity.HasOne(d => d.Line)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.LineId)
                    .HasConstraintName("FK__Flights__LineId__19AACF41");

                entity.HasOne(d => d.Plane)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.PlaneId)
                    .HasConstraintName("FK__Flights__PlaneId__17C286CF");
            });

            modelBuilder.Entity<Line>(entity =>
            {
                entity.HasIndex(e => e.Number, "UQ__Lines__78A1A19DEE8E8448")
                    .IsUnique();

                entity.Property(e => e.IsFree).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Plane>(entity =>
            {
                entity.HasIndex(e => e.Code, "UQ__Planes__A25C5AA71CC57147")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Planes__StaffId__12FDD1B2");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Position__737584F657B28C57")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Tickets__ClientI__1C873BEC");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.FlightId)
                    .HasConstraintName("FK__Tickets__FlightI__1D7B6025");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.HasIndex(e => e.Login, "UQ__Staff__5E55825B54448F46")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "UQ__Staff__737584F64563ABD9")
                    .IsUnique();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff__PositionI__0F2D40CE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
