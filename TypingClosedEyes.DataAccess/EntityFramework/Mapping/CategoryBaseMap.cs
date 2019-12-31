using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Abstract;

namespace TypingClosedEyes.DataAccess.EntityFramework.Mapping
{
    public class CategoryBaseMap : IEntityTypeConfiguration<CategoryBase>
    {
        public void Configure(EntityTypeBuilder<CategoryBase> builder)
        {
            builder.HasKey(p => p.EntityId);
            builder.Property(p => p.EntityId).ValueGeneratedOnAdd();
        }
    }
}
