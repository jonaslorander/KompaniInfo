﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using KompaniInfo.Models;

namespace KompaniInfo.Migrations
{
    [DbContext(typeof(KompaniInfoContext))]
    [Migration("20160831190136_Bild")]
    partial class Bild
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KompaniInfo.Models.Bild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Data");

                    b.Property<string>("Namn")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 250);

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 5);

                    b.HasKey("Id");

                    b.ToTable("Bild");
                });

            modelBuilder.Entity("KompaniInfo.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Innehall")
                        .IsRequired();

                    b.Property<string>("Rubrik")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 180);

                    b.HasKey("Id");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("KompaniInfo.Models.Sida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Innehall")
                        .IsRequired();

                    b.Property<string>("Namn")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("Id");

                    b.ToTable("Sida");
                });
        }
    }
}
