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
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                .IsRequired();

            builder.HasData(
                new Person() { Id=1, Name="Ahmet Demir"},
                new Person() { Id=2, Name="Ece Bal"},
                new Person() { Id=3, Name="Murat Kuğu"},
                new Person() { Id=4, Name="Zeynep Kuyu"},
                new Person() { Id=5, Name="Deniz Efe"});
        }
    }
}
