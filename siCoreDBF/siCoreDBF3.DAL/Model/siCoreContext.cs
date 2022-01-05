using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace siCoreDBF3.DAL.Model
{
    public partial class siCoreContext : DbContext
    {
        public siCoreContext()
        {
        }

        public siCoreContext(DbContextOptions<siCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Basketbol1920SezonEuro> Basketbol1920SezonEuro { get; set; }
        public virtual DbSet<Basketbol1920SezonNbaEast> Basketbol1920SezonNbaEast { get; set; }
        public virtual DbSet<Basketbol1920SezonNbaWest> Basketbol1920SezonNbaWest { get; set; }
        public virtual DbSet<Basketbol1920SezonTr> Basketbol1920SezonTr { get; set; }
        public virtual DbSet<Basketbol2021SezonEuro> Basketbol2021SezonEuro { get; set; }
        public virtual DbSet<Basketbol2021SezonNbaEast> Basketbol2021SezonNbaEast { get; set; }
        public virtual DbSet<Basketbol2021SezonNbaWest> Basketbol2021SezonNbaWest { get; set; }
        public virtual DbSet<Basketbol2021SezonTr> Basketbol2021SezonTr { get; set; }
        public virtual DbSet<Basketbol2122SezonEuro> Basketbol2122SezonEuro { get; set; }
        public virtual DbSet<Basketbol2122SezonNbaEast> Basketbol2122SezonNbaEast { get; set; }
        public virtual DbSet<Basketbol2122SezonNbaWest> Basketbol2122SezonNbaWest { get; set; }
        public virtual DbSet<Basketbol2122SezonTr> Basketbol2122SezonTr { get; set; }
        public virtual DbSet<BasketbolTakimlar> BasketbolTakimlar { get; set; }
        public virtual DbSet<Basketbolcular1920Euro> Basketbolcular1920Euro { get; set; }
        public virtual DbSet<Basketbolcular1920NbaEast> Basketbolcular1920NbaEast { get; set; }
        public virtual DbSet<Basketbolcular1920NbaWest> Basketbolcular1920NbaWest { get; set; }
        public virtual DbSet<Basketbolcular1920Tr> Basketbolcular1920Tr { get; set; }
        public virtual DbSet<Basketbolcular2021Euro> Basketbolcular2021Euro { get; set; }
        public virtual DbSet<Basketbolcular2021NbaEast> Basketbolcular2021NbaEast { get; set; }
        public virtual DbSet<Basketbolcular2021NbaWest> Basketbolcular2021NbaWest { get; set; }
        public virtual DbSet<Basketbolcular2021Tr> Basketbolcular2021Tr { get; set; }
        public virtual DbSet<Basketbolcular2122Euro> Basketbolcular2122Euro { get; set; }
        public virtual DbSet<Basketbolcular2122NbaEast> Basketbolcular2122NbaEast { get; set; }
        public virtual DbSet<Basketbolcular2122NbaWest> Basketbolcular2122NbaWest { get; set; }
        public virtual DbSet<Basketbolcular2122Tr> Basketbolcular2122Tr { get; set; }
        public virtual DbSet<F119Pilotlar> F119Pilotlar { get; set; }
        public virtual DbSet<F119Takimlar> F119Takimlar { get; set; }
        public virtual DbSet<F120Pilotlar> F120Pilotlar { get; set; }
        public virtual DbSet<F120Takimlar> F120Takimlar { get; set; }
        public virtual DbSet<F121Pilotlar> F121Pilotlar { get; set; }
        public virtual DbSet<F121Takimlar> F121Takimlar { get; set; }
        public virtual DbSet<F1Pilotlar> F1Pilotlar { get; set; }
        public virtual DbSet<F1Takimlar> F1Takimlar { get; set; }
        public virtual DbSet<Futbol1920SezonEng> Futbol1920SezonEng { get; set; }
        public virtual DbSet<Futbol1920SezonIta> Futbol1920SezonIta { get; set; }
        public virtual DbSet<Futbol1920SezonTr> Futbol1920SezonTr { get; set; }
        public virtual DbSet<Futbol2021SezonEng> Futbol2021SezonEng { get; set; }
        public virtual DbSet<Futbol2021SezonIta> Futbol2021SezonIta { get; set; }
        public virtual DbSet<Futbol2021SezonTr> Futbol2021SezonTr { get; set; }
        public virtual DbSet<Futbol2122SezonEng> Futbol2122SezonEng { get; set; }
        public virtual DbSet<Futbol2122SezonIta> Futbol2122SezonIta { get; set; }
        public virtual DbSet<Futbol2122SezonTr> Futbol2122SezonTr { get; set; }
        public virtual DbSet<FutbolTakimlar> FutbolTakimlar { get; set; }
        public virtual DbSet<Futbolcular1920Eng> Futbolcular1920Eng { get; set; }
        public virtual DbSet<Futbolcular1920Ita> Futbolcular1920Ita { get; set; }
        public virtual DbSet<Futbolcular1920Tr> Futbolcular1920Tr { get; set; }
        public virtual DbSet<Futbolcular2021Eng> Futbolcular2021Eng { get; set; }
        public virtual DbSet<Futbolcular2021Ita> Futbolcular2021Ita { get; set; }
        public virtual DbSet<Futbolcular2021Tr> Futbolcular2021Tr { get; set; }
        public virtual DbSet<Futbolcular2122Eng> Futbolcular2122Eng { get; set; }
        public virtual DbSet<Futbolcular2122Ita> Futbolcular2122Ita { get; set; }
        public virtual DbSet<Futbolcular2122Tr> Futbolcular2122Tr { get; set; }
        public virtual DbSet<TableName> TableName { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=siCore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basketbol1920SezonEuro>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_19_20_sezon_euro");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet).HasColumnName("takim_galibiyet");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol1920SezonEuro)
                    .HasForeignKey<Basketbol1920SezonEuro>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__793DFFAF");
            });

            modelBuilder.Entity<Basketbol1920SezonNbaEast>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_19_20_sezon_nba_east");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol1920SezonNbaEast)
                    .HasForeignKey<Basketbol1920SezonNbaEast>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__46B27FE2");
            });

            modelBuilder.Entity<Basketbol1920SezonNbaWest>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_19_20_sezon_nba_west");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol1920SezonNbaWest)
                    .HasForeignKey<Basketbol1920SezonNbaWest>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__40058253");
            });

            modelBuilder.Entity<Basketbol1920SezonTr>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_19_20_sezon_tr");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol1920SezonTr)
                    .HasForeignKey<Basketbol1920SezonTr>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__208CD6FA");
            });

            modelBuilder.Entity<Basketbol2021SezonEuro>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_20_21_sezon_euro");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol2021SezonEuro)
                    .HasForeignKey<Basketbol2021SezonEuro>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__00DF2177");
            });

            modelBuilder.Entity<Basketbol2021SezonNbaEast>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_20_21_sezon_nba_east");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol2021SezonNbaEast)
                    .HasForeignKey<Basketbol2021SezonNbaEast>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__540C7B00");
            });

            modelBuilder.Entity<Basketbol2021SezonNbaWest>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_20_21_sezon_nba_west");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol2021SezonNbaWest)
                    .HasForeignKey<Basketbol2021SezonNbaWest>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__4D5F7D71");
            });

            modelBuilder.Entity<Basketbol2021SezonTr>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_20_21_sezon_tr");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol2021SezonTr)
                    .HasForeignKey<Basketbol2021SezonTr>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__282DF8C2");
            });

            modelBuilder.Entity<Basketbol2122SezonEuro>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_21_22_sezon_euro");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol2122SezonEuro)
                    .HasForeignKey<Basketbol2122SezonEuro>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__0880433F");
            });

            modelBuilder.Entity<Basketbol2122SezonNbaEast>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_21_22_sezon_nba_east");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol2122SezonNbaEast)
                    .HasForeignKey<Basketbol2122SezonNbaEast>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__6166761E");
            });

            modelBuilder.Entity<Basketbol2122SezonNbaWest>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_21_22_sezon_nba_west");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol2122SezonNbaWest)
                    .HasForeignKey<Basketbol2122SezonNbaWest>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__5AB9788F");
            });

            modelBuilder.Entity<Basketbol2122SezonTr>(entity =>
            {
                entity.HasKey(e => e.TakimId);

                entity.ToTable("basketbol_21_22_sezon_tr");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanBasket)
                    .HasColumnName("takim_atılan_basket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenBasket)
                    .HasColumnName("takim_yenilen_basket")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Basketbol2122SezonTr)
                    .HasForeignKey<Basketbol2122SezonTr>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__2FCF1A8A");
            });

            modelBuilder.Entity<BasketbolTakimlar>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__basketbo__FA72EA0E296429C4");

                entity.ToTable("basketbol_takimlar");

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.TakimAdi)
                    .HasColumnName("takim_adi")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Basketbolcular1920Euro>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E467B907B1");

                entity.ToTable("basketbolcular_19_20_euro");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular1920Euro)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__11158940");
            });

            modelBuilder.Entity<Basketbolcular1920NbaEast>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E440CB60DC");

                entity.ToTable("basketbolcular_19_20_nba_east");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular1920NbaEast)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__6BE40491");
            });

            modelBuilder.Entity<Basketbolcular1920NbaWest>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E4E689A468");

                entity.ToTable("basketbolcular_19_20_nba_west");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular1920NbaWest)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__690797E6");
            });

            modelBuilder.Entity<Basketbolcular1920Tr>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E49DA63211");

                entity.ToTable("basketbolcular_19_20_tr");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular1920Tr)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__3864608B");
            });

            modelBuilder.Entity<Basketbolcular2021Euro>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E4D0F59D3D");

                entity.ToTable("basketbolcular_20_21_euro");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular2021Euro)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__13F1F5EB");
            });

            modelBuilder.Entity<Basketbolcular2021NbaEast>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E49988EBE5");

                entity.ToTable("basketbolcular_20_21_nba_east");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular2021NbaEast)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__719CDDE7");
            });

            modelBuilder.Entity<Basketbolcular2021NbaWest>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E43B3CFF6C");

                entity.ToTable("basketbolcular_20_21_nba_west");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular2021NbaWest)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__6EC0713C");
            });

            modelBuilder.Entity<Basketbolcular2021Tr>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E45D7A139C");

                entity.ToTable("basketbolcular_20_21_tr");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular2021Tr)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__3B40CD36");
            });

            modelBuilder.Entity<Basketbolcular2122Euro>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E4A82EE461");

                entity.ToTable("basketbolcular_21_22_euro");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular2122Euro)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__16CE6296");
            });

            modelBuilder.Entity<Basketbolcular2122NbaEast>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E4948CD6C8");

                entity.ToTable("basketbolcular_21_22_nba_east");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular2122NbaEast)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__7755B73D");
            });

            modelBuilder.Entity<Basketbolcular2122NbaWest>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E46653DEE8");

                entity.ToTable("basketbolcular_21_22_nba_west");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular2122NbaWest)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__74794A92");
            });

            modelBuilder.Entity<Basketbolcular2122Tr>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__basketbo__A631E7E4F46AF10F");

                entity.ToTable("basketbolcular_21_22_tr");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanBasketOrtalamasi).HasColumnName("atilan_basket_ortalamasi");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsistOrtalamasi).HasColumnName("yapilan_asist_ortalamasi");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Basketbolcular2122Tr)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__basketbol__takim__3E1D39E1");
            });

            modelBuilder.Entity<F119Pilotlar>(entity =>
            {
                entity.HasKey(e => e.PilotId)
                    .HasName("PK__f1_19_pi__FFF8AECE39C4B990");

                entity.ToTable("f1_19_pilotlar");

                entity.Property(e => e.PilotId)
                    .HasColumnName("pilot_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Podium).HasColumnName("podium");

                entity.Property(e => e.PolePosition).HasColumnName("pole_position");

                entity.Property(e => e.Puan).HasColumnName("puan");

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.Win).HasColumnName("win");

                entity.HasOne(d => d.Pilot)
                    .WithOne(p => p.F119Pilotlar)
                    .HasForeignKey<F119Pilotlar>(d => d.PilotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_19_pil__pilot__668030F6");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.F119Pilotlar)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_19_pil__takim__658C0CBD");
            });

            modelBuilder.Entity<F119Takimlar>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__f1_19_ta__FA72EA0E183C569A");

                entity.ToTable("f1_19_takimlar");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimPuan).HasColumnName("takim_puan");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.F119Takimlar)
                    .HasForeignKey<F119Takimlar>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_19_tak__takim__62AFA012");
            });

            modelBuilder.Entity<F120Pilotlar>(entity =>
            {
                entity.HasKey(e => e.PilotId)
                    .HasName("PK__f1_20_pi__FFF8AECEC3340987");

                entity.ToTable("f1_20_pilotlar");

                entity.Property(e => e.PilotId)
                    .HasColumnName("pilot_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Podium).HasColumnName("podium");

                entity.Property(e => e.PolePosition).HasColumnName("pole_position");

                entity.Property(e => e.Puan).HasColumnName("puan");

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.Win).HasColumnName("win");

                entity.HasOne(d => d.Pilot)
                    .WithOne(p => p.F120Pilotlar)
                    .HasForeignKey<F120Pilotlar>(d => d.PilotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_20_pil__pilot__6D2D2E85");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.F120Pilotlar)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_20_pil__takim__6C390A4C");
            });

            modelBuilder.Entity<F120Takimlar>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__f1_20_ta__FA72EA0E063EA14A");

                entity.ToTable("f1_20_takimlar");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimPuan).HasColumnName("takim_puan");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.F120Takimlar)
                    .HasForeignKey<F120Takimlar>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_20_tak__takim__695C9DA1");
            });

            modelBuilder.Entity<F121Pilotlar>(entity =>
            {
                entity.HasKey(e => e.PilotId)
                    .HasName("PK__f1_21_pi__FFF8AECE1FF5CA9B");

                entity.ToTable("f1_21_pilotlar");

                entity.Property(e => e.PilotId)
                    .HasColumnName("pilot_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Podium).HasColumnName("podium");

                entity.Property(e => e.PolePosition).HasColumnName("pole_position");

                entity.Property(e => e.Puan).HasColumnName("puan");

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.Win).HasColumnName("win");

                entity.HasOne(d => d.Pilot)
                    .WithOne(p => p.F121Pilotlar)
                    .HasForeignKey<F121Pilotlar>(d => d.PilotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_21_pil__pilot__73DA2C14");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.F121Pilotlar)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_21_pil__takim__72E607DB");
            });

            modelBuilder.Entity<F121Takimlar>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__f1_21_ta__FA72EA0EBF4EDB6B");

                entity.ToTable("f1_21_takimlar");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimPuan).HasColumnName("takim_puan");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.F121Takimlar)
                    .HasForeignKey<F121Takimlar>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__f1_21_tak__takim__70099B30");
            });

            modelBuilder.Entity<F1Pilotlar>(entity =>
            {
                entity.HasKey(e => e.PilotId)
                    .HasName("PK__f1_pilot__FFF8AECE63248064");

                entity.ToTable("f1_pilotlar");

                entity.Property(e => e.PilotId)
                    .HasColumnName("pilot_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PilotName)
                    .HasColumnName("pilot_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<F1Takimlar>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__f1_takim__FA72EA0E28E534EF");

                entity.ToTable("f1_takimlar");

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.TakimAdi)
                    .HasColumnName("takim_adi")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Futbol1920SezonEng>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_1__FA72EA0ED1C751C9");

                entity.ToTable("futbol_19_20_sezon_eng");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol1920SezonEng)
                    .HasForeignKey<Futbol1920SezonEng>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_19__takim__1DD065E0");
            });

            modelBuilder.Entity<Futbol1920SezonIta>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_1__FA72EA0EC16F68E1");

                entity.ToTable("futbol_19_20_sezon_ita");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol1920SezonIta)
                    .HasForeignKey<Futbol1920SezonIta>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_19__takim__4301EA8F");
            });

            modelBuilder.Entity<Futbol1920SezonTr>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_1__FA72EA0ECFF03C21");

                entity.ToTable("futbol_19_20_sezon_tr");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol1920SezonTr)
                    .HasForeignKey<Futbol1920SezonTr>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_19__takim__789EE131");
            });

            modelBuilder.Entity<Futbol2021SezonEng>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_2__FA72EA0EDE90D80A");

                entity.ToTable("futbol_20_21_sezon_eng");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol2021SezonEng)
                    .HasForeignKey<Futbol2021SezonEng>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_20__takim__2759D01A");
            });

            modelBuilder.Entity<Futbol2021SezonIta>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_2__FA72EA0E27529C74");

                entity.ToTable("futbol_20_21_sezon_ita");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol2021SezonIta)
                    .HasForeignKey<Futbol2021SezonIta>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_20__takim__4C8B54C9");
            });

            modelBuilder.Entity<Futbol2021SezonTr>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_2__FA72EA0EC02258E0");

                entity.ToTable("futbol_20_21_sezon_tr");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol2021SezonTr)
                    .HasForeignKey<Futbol2021SezonTr>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_20__takim__02284B6B");
            });

            modelBuilder.Entity<Futbol2122SezonEng>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_2__FA72EA0ED44AFC17");

                entity.ToTable("futbol_21_22_sezon_eng");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol2122SezonEng)
                    .HasForeignKey<Futbol2122SezonEng>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_21__takim__30E33A54");
            });

            modelBuilder.Entity<Futbol2122SezonIta>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_2__FA72EA0EA761BD07");

                entity.ToTable("futbol_21_22_sezon_ita");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol2122SezonIta)
                    .HasForeignKey<Futbol2122SezonIta>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_21__takim__5614BF03");
            });

            modelBuilder.Entity<Futbol2122SezonTr>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_2__FA72EA0E117E61ED");

                entity.ToTable("futbol_21_22_sezon_tr");

                entity.Property(e => e.TakimId)
                    .HasColumnName("takim_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TakimAtılanGol)
                    .HasColumnName("takim_atılan_gol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimAveraj)
                    .HasColumnName("takim_averaj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimBeraberlik)
                    .HasColumnName("takim_beraberlik")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimGalibiyet)
                    .HasColumnName("takim_galibiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimMaglubiyet)
                    .HasColumnName("takim_maglubiyet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimPuan)
                    .HasColumnName("takim_puan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakimYenilenGol)
                    .HasColumnName("takim_yenilen_gol")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Takim)
                    .WithOne(p => p.Futbol2122SezonTr)
                    .HasForeignKey<Futbol2122SezonTr>(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbol_21__takim__0BB1B5A5");
            });

            modelBuilder.Entity<FutbolTakimlar>(entity =>
            {
                entity.HasKey(e => e.TakimId)
                    .HasName("PK__futbol_t__FA72EA0E8520CA3A");

                entity.ToTable("futbol_takimlar");

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.TakimAdi)
                    .IsRequired()
                    .HasColumnName("takim_adi")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Futbolcular1920Eng>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E4E83E51C6");

                entity.ToTable("futbolcular_19_20_eng");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular1920Eng)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__3A6CA48E");
            });

            modelBuilder.Entity<Futbolcular1920Ita>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E4C26B487A");

                entity.ToTable("futbolcular_19_20_ita");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular1920Ita)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__5F9E293D");
            });

            modelBuilder.Entity<Futbolcular1920Tr>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E4D18D3563");

                entity.ToTable("futbolcular_19_20_tr");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular1920Tr)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__153B1FDF");
            });

            modelBuilder.Entity<Futbolcular2021Eng>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E45A19EB90");

                entity.ToTable("futbolcular_20_21_eng");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular2021Eng)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__3D491139");
            });

            modelBuilder.Entity<Futbolcular2021Ita>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E4D129E315");

                entity.ToTable("futbolcular_20_21_ita");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular2021Ita)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__627A95E8");
            });

            modelBuilder.Entity<Futbolcular2021Tr>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E4656CA740");

                entity.ToTable("futbolcular_20_21_tr");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular2021Tr)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__18178C8A");
            });

            modelBuilder.Entity<Futbolcular2122Eng>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E4C2ECA820");

                entity.ToTable("futbolcular_21_22_eng");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular2122Eng)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__40257DE4");
            });

            modelBuilder.Entity<Futbolcular2122Ita>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E4A2C4D701");

                entity.ToTable("futbolcular_21_22_ita");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular2122Ita)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__65570293");
            });

            modelBuilder.Entity<Futbolcular2122Tr>(entity =>
            {
                entity.HasKey(e => e.FutbolcuId)
                    .HasName("PK__futbolcu__A631E7E43E99DD07");

                entity.ToTable("futbolcular_21_22_tr");

                entity.Property(e => e.FutbolcuId)
                    .HasColumnName("futbolcu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtilanGol).HasColumnName("atilan_gol");

                entity.Property(e => e.FutbolcuIsim)
                    .IsRequired()
                    .HasColumnName("futbolcu_isim")
                    .HasMaxLength(30);

                entity.Property(e => e.TakimId).HasColumnName("takim_id");

                entity.Property(e => e.YapilanAsist).HasColumnName("yapilan_asist");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Futbolcular2122Tr)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__futbolcul__takim__1AF3F935");
            });

            modelBuilder.Entity<TableName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table_name");

                entity.Property(e => e.Column1).HasColumnName("column1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
