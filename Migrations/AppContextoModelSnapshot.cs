﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TDSTecnologia.FaceAlbum.Web.Data;

namespace TDSTecnologia.FaceAlbum.Web.Migrations
{
    [DbContext(typeof(AppContexto))]
    partial class AppContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TDSTecnologia.FaceAlbum.Web.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Capa")
                        .HasColumnName("capa");

                    b.Property<DateTime>("DataFim")
                        .HasColumnName("dt_fim");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnName("dt_inicio");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasMaxLength(50);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("titulo")
                        .HasMaxLength(50);

                    b.HasKey("AlbumId");

                    b.ToTable("tb01_album");
                });

            modelBuilder.Entity("TDSTecnologia.FaceAlbum.Web.Models.Imagem", b =>
                {
                    b.Property<int>("ImagemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("AlbumId")
                        .HasColumnName("album");

                    b.Property<string>("Link")
                        .HasColumnName("link");

                    b.HasKey("ImagemId");

                    b.HasIndex("AlbumId");

                    b.ToTable("tb02_imagem");
                });

            modelBuilder.Entity("TDSTecnologia.FaceAlbum.Web.Models.Imagem", b =>
                {
                    b.HasOne("TDSTecnologia.FaceAlbum.Web.Models.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
