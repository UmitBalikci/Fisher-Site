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
    public class BlockConfiguration : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {
            builder.HasKey(bl => bl.Id);
            builder.Property(bl => bl.Name)
                .IsRequired();

            builder.HasData(
                new Block() { Id=1, Name="A Block"},
                new Block() { Id=2, Name="B Block"},
                new Block() { Id=3, Name="C Block"},
                new Block() { Id=4, Name="D Block"},
                new Block() { Id=5, Name="E Block"});
        }
    }
}
