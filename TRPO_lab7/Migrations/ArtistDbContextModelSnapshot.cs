﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TRPO_lab7.Models;

#nullable disable

namespace TRPO_lab7.Migrations
{
    [DbContext(typeof(ArtistDbContext))]
    partial class ArtistDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TRPO_lab7.Models.ArtOrder", b =>
                {
                    b.Property<int>("ArtOrderId")
                        .HasColumnType("int")
                        .HasColumnName("artOrderID");

                    b.Property<string>("AdditionalRequests")
                        .HasColumnType("text")
                        .HasColumnName("additionalRequests");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int")
                        .HasColumnName("artistID");

                    b.Property<string>("ArtworkDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("artworkDescription");

                    b.Property<string>("CanvasSize")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("canvasSize");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("customerEmail");

                    b.Property<string>("CustomerFullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("customerFullName");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("customerPhone");

                    b.Property<DateOnly?>("Deadline")
                        .HasColumnType("date")
                        .HasColumnName("deadline");

                    b.Property<string>("SocialMediaLink")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("socialMediaLink");

                    b.HasKey("ArtOrderId")
                        .HasName("PK__ArtOrder__64ED6C94495D2E9F");

                    b.HasIndex("ArtistId");

                    b.ToTable("ArtOrder", (string)null);
                });

            modelBuilder.Entity("TRPO_lab7.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int")
                        .HasColumnName("artistID");

                    b.Property<string>("Biography")
                        .HasColumnType("text")
                        .HasColumnName("biography");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.Property<string>("Telegram")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("telegram");

                    b.Property<string>("Vk")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("vk");

                    b.HasKey("ArtistId")
                        .HasName("PK__Artist__4F439367D89E7DD8");

                    b.ToTable("Artist", (string)null);
                });

            modelBuilder.Entity("TRPO_lab7.Models.Artwork", b =>
                {
                    b.Property<int>("ArtworkId")
                        .HasColumnType("int")
                        .HasColumnName("artworkID");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int")
                        .HasColumnName("artistID");

                    b.Property<string>("ArtworkUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("artworkURL");

                    b.Property<string>("CanvasSize")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("canvasSize");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("price");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("title");

                    b.HasKey("ArtworkId")
                        .HasName("PK__Artwork__09DA4903253991F4");

                    b.HasIndex("ArtistId");

                    b.ToTable("Artwork", (string)null);
                });

            modelBuilder.Entity("TRPO_lab7.Models.ArtworkPurchase", b =>
                {
                    b.Property<int>("AtworkPurchaseId")
                        .HasColumnType("int")
                        .HasColumnName("atworkPurchaseID");

                    b.Property<int>("ArtworkId")
                        .HasColumnType("int")
                        .HasColumnName("artworkID");

                    b.Property<string>("CustomerFullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("customerFullName");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("customerPhone");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("deliveryAddress");

                    b.Property<DateOnly>("OrderDate")
                        .HasColumnType("date")
                        .HasColumnName("orderDate");

                    b.HasKey("AtworkPurchaseId")
                        .HasName("PK__ArtworkP__34B426C0BB959372");

                    b.HasIndex("ArtworkId");

                    b.ToTable("ArtworkPurchase", (string)null);
                });

            modelBuilder.Entity("TRPO_lab7.Models.PortfolioArtwork", b =>
                {
                    b.Property<int>("PortfolioArtworkId")
                        .HasColumnType("int")
                        .HasColumnName("portfolioArtworkID");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int")
                        .HasColumnName("artistID");

                    b.Property<string>("ArtworkUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("artworkURL");

                    b.Property<string>("CanvasSize")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("canvasSize");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("title");

                    b.HasKey("PortfolioArtworkId")
                        .HasName("PK__Portfoli__5513D49346A71F13");

                    b.HasIndex("ArtistId");

                    b.ToTable("PortfolioArtwork", (string)null);
                });

            modelBuilder.Entity("TRPO_lab7.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .HasColumnType("int")
                        .HasColumnName("reviewID");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int")
                        .HasColumnName("artistID");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("reviewText");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("reviewerName");

                    b.Property<DateOnly>("SubmissionDate")
                        .HasColumnType("date")
                        .HasColumnName("submissionDate");

                    b.HasKey("ReviewId")
                        .HasName("PK__Review__2ECD6E24E879D40A");

                    b.HasIndex("ArtistId");

                    b.ToTable("Review", (string)null);
                });

            modelBuilder.Entity("TRPO_lab7.Models.ArtOrder", b =>
                {
                    b.HasOne("TRPO_lab7.Models.Artist", "Artist")
                        .WithMany("ArtOrders")
                        .HasForeignKey("ArtistId")
                        .IsRequired()
                        .HasConstraintName("FK__ArtOrder__artist__2F10007B");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("TRPO_lab7.Models.Artwork", b =>
                {
                    b.HasOne("TRPO_lab7.Models.Artist", "Artist")
                        .WithMany("Artworks")
                        .HasForeignKey("ArtistId")
                        .IsRequired()
                        .HasConstraintName("FK__Artwork__artistI__267ABA7A");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("TRPO_lab7.Models.ArtworkPurchase", b =>
                {
                    b.HasOne("TRPO_lab7.Models.Artwork", "Artwork")
                        .WithMany("ArtworkPurchases")
                        .HasForeignKey("ArtworkId")
                        .IsRequired()
                        .HasConstraintName("FK__ArtworkPu__artwo__29572725");

                    b.Navigation("Artwork");
                });

            modelBuilder.Entity("TRPO_lab7.Models.PortfolioArtwork", b =>
                {
                    b.HasOne("TRPO_lab7.Models.Artist", "Artist")
                        .WithMany("PortfolioArtworks")
                        .HasForeignKey("ArtistId")
                        .IsRequired()
                        .HasConstraintName("FK__Portfolio__artis__2C3393D0");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("TRPO_lab7.Models.Review", b =>
                {
                    b.HasOne("TRPO_lab7.Models.Artist", "Artist")
                        .WithMany("Reviews")
                        .HasForeignKey("ArtistId")
                        .IsRequired()
                        .HasConstraintName("FK__Review__artistID__31EC6D26");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("TRPO_lab7.Models.Artist", b =>
                {
                    b.Navigation("ArtOrders");

                    b.Navigation("Artworks");

                    b.Navigation("PortfolioArtworks");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("TRPO_lab7.Models.Artwork", b =>
                {
                    b.Navigation("ArtworkPurchases");
                });
#pragma warning restore 612, 618
        }
    }
}
