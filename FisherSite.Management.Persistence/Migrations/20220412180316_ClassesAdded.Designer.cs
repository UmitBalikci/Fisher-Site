// <auto-generated />
using System;
using FisherSite.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FisherSite.Persistence.Migrations
{
    [DbContext(typeof(FisherSiteDbContext))]
    [Migration("20220412180316_ClassesAdded")]
    partial class ClassesAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FisherSite.Domain.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentFloor")
                        .HasColumnType("int");

                    b.Property<int>("ApartmentStateId")
                        .HasColumnType("int");

                    b.Property<int>("ApartmentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("BlockId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentStateId");

                    b.HasIndex("ApartmentTypeId");

                    b.HasIndex("BlockId");

                    b.HasIndex("PersonId");

                    b.ToTable("Apartments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentFloor = 5,
                            ApartmentStateId = 1,
                            ApartmentTypeId = 1,
                            BlockId = 1
                        },
                        new
                        {
                            Id = 2,
                            ApartmentFloor = 5,
                            ApartmentStateId = 1,
                            ApartmentTypeId = 1,
                            BlockId = 1
                        },
                        new
                        {
                            Id = 3,
                            ApartmentFloor = 5,
                            ApartmentStateId = 1,
                            ApartmentTypeId = 1,
                            BlockId = 2
                        },
                        new
                        {
                            Id = 4,
                            ApartmentFloor = 5,
                            ApartmentStateId = 2,
                            ApartmentTypeId = 2,
                            BlockId = 2,
                            PersonId = 1
                        },
                        new
                        {
                            Id = 5,
                            ApartmentFloor = 5,
                            ApartmentStateId = 2,
                            ApartmentTypeId = 2,
                            BlockId = 3,
                            PersonId = 2
                        },
                        new
                        {
                            Id = 6,
                            ApartmentFloor = 5,
                            ApartmentStateId = 2,
                            ApartmentTypeId = 3,
                            BlockId = 4,
                            PersonId = 3
                        });
                });

            modelBuilder.Entity("FisherSite.Domain.ApartmentState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApartmentStates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Empty"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Full"
                        });
                });

            modelBuilder.Entity("FisherSite.Domain.ApartmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApartmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1+1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "2+1"
                        },
                        new
                        {
                            Id = 3,
                            Name = "3+1"
                        },
                        new
                        {
                            Id = 4,
                            Name = "4+1"
                        });
                });

            modelBuilder.Entity("FisherSite.Domain.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "A Block"
                        },
                        new
                        {
                            Id = 2,
                            Name = "B Block"
                        },
                        new
                        {
                            Id = 3,
                            Name = "C Block"
                        },
                        new
                        {
                            Id = 4,
                            Name = "D Block"
                        },
                        new
                        {
                            Id = 5,
                            Name = "E Block"
                        });
                });

            modelBuilder.Entity("FisherSite.Domain.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ahmet Demir"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ece Bal"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Murat Kuğu"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Zeynep Kuyu"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Deniz Efe"
                        });
                });

            modelBuilder.Entity("FisherSite.Domain.Apartment", b =>
                {
                    b.HasOne("FisherSite.Domain.ApartmentState", "ApartmentState")
                        .WithMany()
                        .HasForeignKey("ApartmentStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FisherSite.Domain.ApartmentType", "ApartmentType")
                        .WithMany()
                        .HasForeignKey("ApartmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FisherSite.Domain.Block", "Block")
                        .WithMany()
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FisherSite.Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("ApartmentState");

                    b.Navigation("ApartmentType");

                    b.Navigation("Block");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
