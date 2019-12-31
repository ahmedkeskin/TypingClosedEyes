using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Abstract;

namespace TypingClosedEyes.DataAccess.EntityFramework.Mapping
{
    public class GrammarBaseMap : IEntityTypeConfiguration<GrammarBase>
    {
        public void Configure(EntityTypeBuilder<GrammarBase> builder)
        {
            builder.HasKey(p => p.EntityId);
            builder.Property(p => p.EntityId).ValueGeneratedOnAdd();
        }
    }
}
