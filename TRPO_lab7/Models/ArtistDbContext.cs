using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TRPO_lab7.Models;

public partial class ArtistDbContext : DbContext
{
    public ArtistDbContext()
    {
    }

    public ArtistDbContext(DbContextOptions<ArtistDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ArtOrder> ArtOrders { get; set; }

    public virtual DbSet<Artist> Artists { get; set; }

    public virtual DbSet<Artwork> Artworks { get; set; }

    public virtual DbSet<ArtworkPurchase> ArtworkPurchases { get; set; }

    public virtual DbSet<PortfolioArtwork> PortfolioArtworks { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-NSNU3CD4\\SQLEXPRESS;Database=artistDB;Trusted_Connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArtOrder>(entity =>
        {
            entity.HasKey(e => e.ArtOrderId).HasName("PK__ArtOrder__64ED6C94495D2E9F");

            entity.ToTable("ArtOrder");

            entity.Property(e => e.ArtOrderId)
                .ValueGeneratedNever()
                .HasColumnName("artOrderID");
            entity.Property(e => e.AdditionalRequests)
                .HasColumnType("text")
                .HasColumnName("additionalRequests");
            entity.Property(e => e.ArtistId).HasColumnName("artistID");
            entity.Property(e => e.ArtworkDescription)
                .HasColumnType("text")
                .HasColumnName("artworkDescription");
            entity.Property(e => e.CanvasSize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("canvasSize");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("customerEmail");
            entity.Property(e => e.CustomerFullName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("customerFullName");
            entity.Property(e => e.CustomerPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("customerPhone");
            entity.Property(e => e.Deadline).HasColumnName("deadline");
            entity.Property(e => e.SocialMediaLink)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("socialMediaLink");

            entity.HasOne(d => d.Artist).WithMany(p => p.ArtOrders)
                .HasForeignKey(d => d.ArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ArtOrder__artist__2F10007B");
        });

        modelBuilder.Entity<Artist>(entity =>
        {
            entity.HasKey(e => e.ArtistId).HasName("PK__Artist__4F439367D89E7DD8");

            entity.ToTable("Artist");

            entity.Property(e => e.ArtistId)
                .ValueGeneratedNever()
                .HasColumnName("artistID");
            entity.Property(e => e.Biography)
                .HasColumnType("text")
                .HasColumnName("biography");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Telegram)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("telegram");
            entity.Property(e => e.Vk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("vk");
        });

        modelBuilder.Entity<Artwork>(entity =>
        {
            entity.HasKey(e => e.ArtworkId).HasName("PK__Artwork__09DA4903253991F4");

            entity.ToTable("Artwork");

            entity.Property(e => e.ArtworkId)
                .ValueGeneratedNever()
                .HasColumnName("artworkID");
            entity.Property(e => e.ArtistId).HasColumnName("artistID");
            entity.Property(e => e.ArtworkUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("artworkURL");
            entity.Property(e => e.CanvasSize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("canvasSize");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.Artist).WithMany(p => p.Artworks)
                .HasForeignKey(d => d.ArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Artwork__artistI__267ABA7A");
        });

        modelBuilder.Entity<ArtworkPurchase>(entity =>
        {
            entity.HasKey(e => e.AtworkPurchaseId).HasName("PK__ArtworkP__34B426C0BB959372");

            entity.ToTable("ArtworkPurchase");

            entity.Property(e => e.AtworkPurchaseId)
                .ValueGeneratedNever()
                .HasColumnName("atworkPurchaseID");
            entity.Property(e => e.ArtworkId).HasColumnName("artworkID");
            entity.Property(e => e.CustomerFullName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("customerFullName");
            entity.Property(e => e.CustomerPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("customerPhone");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("deliveryAddress");
            entity.Property(e => e.OrderDate).HasColumnName("orderDate");

            entity.HasOne(d => d.Artwork).WithMany(p => p.ArtworkPurchases)
                .HasForeignKey(d => d.ArtworkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ArtworkPu__artwo__29572725");
        });

        modelBuilder.Entity<PortfolioArtwork>(entity =>
        {
            entity.HasKey(e => e.PortfolioArtworkId).HasName("PK__Portfoli__5513D49346A71F13");

            entity.ToTable("PortfolioArtwork");

            entity.Property(e => e.PortfolioArtworkId)
                .ValueGeneratedNever()
                .HasColumnName("portfolioArtworkID");
            entity.Property(e => e.ArtistId).HasColumnName("artistID");
            entity.Property(e => e.ArtworkUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("artworkURL");
            entity.Property(e => e.CanvasSize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("canvasSize");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.Artist).WithMany(p => p.PortfolioArtworks)
                .HasForeignKey(d => d.ArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Portfolio__artis__2C3393D0");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Review__2ECD6E24E879D40A");

            entity.ToTable("Review");

            entity.Property(e => e.ReviewId)
                .ValueGeneratedNever()
                .HasColumnName("reviewID");
            entity.Property(e => e.ArtistId).HasColumnName("artistID");
            entity.Property(e => e.ReviewText)
                .HasColumnType("text")
                .HasColumnName("reviewText");
            entity.Property(e => e.ReviewerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("reviewerName");
            entity.Property(e => e.SubmissionDate).HasColumnName("submissionDate");

            entity.HasOne(d => d.Artist).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Review__artistID__31EC6D26");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
