﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using playlistgenerator.Models;

namespace playlist3.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("playlistgenerator.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlaylistId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("playlistgenerator.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaylistId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("playlistgenerator.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("admin")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("playlistgenerator.Models.Song", b =>
                {
                    b.HasOne("playlistgenerator.Models.Playlist", null)
                        .WithMany("songs")
                        .HasForeignKey("PlaylistId");
                });
#pragma warning restore 612, 618
        }
    }
}
