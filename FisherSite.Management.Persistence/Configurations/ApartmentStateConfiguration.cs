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
    public class ApartmentStateConfiguration : IEntityTypeConfiguration<ApartmentState>
    {
        public void Configure(EntityTypeBuilder<ApartmentState> builder)
        {
            builder.HasKey(aps => aps.Id);
            builder.Property(aps => aps.Name)
                .IsRequired();

            builder.HasData(
                new ApartmentState() { Id=1, Name="Empty"},
                new ApartmentState() { Id=2, Name="Full"});
        }
    }
}
