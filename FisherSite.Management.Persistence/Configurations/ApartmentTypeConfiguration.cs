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
    public class ApartmentTypeConfiguration : IEntityTypeConfiguration<ApartmentType>
    {
        public void Configure(EntityTypeBuilder<ApartmentType> builder)
        {
            builder.HasKey(apt => apt.Id);
            builder.Property(apt => apt.Name)
                .IsRequired();
            builder.HasData(
                new ApartmentType() { Id=1, Name="1+1"},
                new ApartmentType() { Id=2, Name="2+1"},
                new ApartmentType() { Id=3, Name="3+1"},
                new ApartmentType() { Id=4, Name="4+1"});
        }
    }
}
