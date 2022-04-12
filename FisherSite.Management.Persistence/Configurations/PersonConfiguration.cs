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
            builder.Property(p => p.IdentityNumber)
                .IsRequired()
                .HasColumnType("char(11)");
            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(50)");
            builder.Property(p => p.Phone)
                .IsRequired()
                .HasColumnType("char(11)");
            builder.Property(p => p.VehicleInfo)
                .HasColumnType("varchar(10)");

            builder.HasData(
                new Person() { Id=1, Name="Ahmet Demir", IdentityNumber="10101010101", Email="ademir@gmail.com", Phone="05301234560", VehicleInfo="34AB1234"},
                new Person() { Id=2, Name="Ece Bal", IdentityNumber = "10101010102", Email = "ebal@gmail.com", Phone = "05301234561", VehicleInfo = "YOK" },
                new Person() { Id=3, Name="Murat Kuğu", IdentityNumber = "10101010103", Email = "mkugu@gmail.com", Phone = "05301234562", VehicleInfo = "34CDF34" },
                new Person() { Id=4, Name="Zeynep Kuyu", IdentityNumber = "10101010104", Email = "zkuyu@gmail.com", Phone = "05301234563", VehicleInfo = "34KL9834" },
                new Person() { Id=5, Name="Deniz Efe", IdentityNumber = "10101010105", Email = "defe@gmail.com", Phone = "05301234564", VehicleInfo = "34RB234" });
        }
    }
}
