﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TriBagageApp.Context;

namespace TriBagageApp.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    [Migration("20200128081715_Riquired message and string codeIATA")]
    partial class RiquiredmessageandstringcodeIATA
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TriBagageApp.Bagage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeIATA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Poids")
                        .HasColumnType("int");

                    b.Property<int>("VolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VolId");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("TriBagageApp.Vol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateVol")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ligne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parking")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vols");
                });

            modelBuilder.Entity("TriBagageApp.Bagage", b =>
                {
                    b.HasOne("TriBagageApp.Vol", null)
                        .WithMany("Bagages")
                        .HasForeignKey("VolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
