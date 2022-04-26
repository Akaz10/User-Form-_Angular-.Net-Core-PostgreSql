
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using User.Data.Entities;

namespace User.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Userx>
    {
        public void Configure(EntityTypeBuilder<Userx> builder)
        {
            builder.Property(s => s.name).HasMaxLength(50);
            builder.Property(s => s.surname).HasMaxLength(50);
            builder.Property(s => s.name).HasMaxLength(50);
            builder.Property(s => s.bDay).HasMaxLength(50);
            builder.Property(s => s.gender).HasMaxLength(50);
        }
    }
}
