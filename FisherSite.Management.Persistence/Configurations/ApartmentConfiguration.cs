using FisherSite.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Persistence.Configurations
{
    public class ApartmentConfiguration : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.HasKey(ap => ap.Id);

            builder.HasOne(ap => ap.Block)
                .WithMany()
                .HasForeignKey(ap => ap.BlockId);

            builder.HasOne(ap => ap.ApartmentState)
                .WithMany()
                .HasForeignKey(ap => ap.ApartmentStateId);

            builder.HasOne(ap => ap.ApartmentType)
                .WithMany()
                .HasForeignKey(ap => ap.ApartmentTypeId);

            builder.Property(ap => ap.ApartmentFloor)
                .IsRequired();

            builder.HasOne(ap => ap.Person)
                .WithMany()
                .HasForeignKey(ap => ap.PersonId);

            builder.HasData(
                new Apartment() { Id = 1, BlockId = 1, ApartmentStateId = 1, ApartmentTypeId = 1, ApartmentFloor = Floor.FifthFloor },
                new Apartment() { Id = 2, BlockId = 1, ApartmentStateId = 1, ApartmentTypeId = 1, ApartmentFloor = Floor.FifthFloor },
                new Apartment() { Id = 3, BlockId = 2, ApartmentStateId = 1, ApartmentTypeId = 1, ApartmentFloor = Floor.FifthFloor },
                new Apartment() { Id = 4, BlockId = 2, ApartmentStateId = 2, ApartmentTypeId = 2, ApartmentFloor = Floor.FifthFloor, PersonId = 1 },
                new Apartment() { Id = 5, BlockId = 3, ApartmentStateId = 2, ApartmentTypeId = 2, ApartmentFloor = Floor.FifthFloor, PersonId = 2 },
                new Apartment() { Id = 6, BlockId = 4, ApartmentStateId = 2, ApartmentTypeId = 3, ApartmentFloor = Floor.FifthFloor, PersonId = 3 });
        }
    }
}
