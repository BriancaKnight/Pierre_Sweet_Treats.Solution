﻿// <auto-generated />
using Bakery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bakery.Migrations
{
    [DbContext(typeof(BakeryContext))]
    [Migration("20240216175708_AddModels")]
    partial class AddModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bakery.Models.Flavor", b =>
                {
                    b.Property<int>("FlavorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FlavorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FlavorId");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("Bakery.Models.FlavorTreat", b =>
                {
                    b.Property<int>("FlavorTreatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FlavorId")
                        .HasColumnType("int");

                    b.Property<int>("TreatId")
                        .HasColumnType("int");

                    b.HasKey("FlavorTreatId");

                    b.HasIndex("FlavorId");

                    b.HasIndex("TreatId");

                    b.ToTable("FlavorTreats");
                });

            modelBuilder.Entity("Bakery.Models.Treat", b =>
                {
                    b.Property<int>("TreatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TreatName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TreatId");

                    b.ToTable("Treats");
                });

            modelBuilder.Entity("Bakery.Models.FlavorTreat", b =>
                {
                    b.HasOne("Bakery.Models.Flavor", "Flavor")
                        .WithMany("JoinEntities")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Models.Treat", "Treat")
                        .WithMany("JoinEntities")
                        .HasForeignKey("TreatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flavor");

                    b.Navigation("Treat");
                });

            modelBuilder.Entity("Bakery.Models.Flavor", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Bakery.Models.Treat", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
