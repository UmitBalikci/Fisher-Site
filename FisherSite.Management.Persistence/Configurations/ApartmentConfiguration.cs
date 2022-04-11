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
        }
    }
}
