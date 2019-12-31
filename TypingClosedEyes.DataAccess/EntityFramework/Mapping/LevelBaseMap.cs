using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Abstract;

namespace TypingClosedEyes.DataAccess.EntityFramework.Mapping
{
    public class LevelBaseMap : IEntityTypeConfiguration<LevelBase>
    {
        public void Configure(EntityTypeBuilder<LevelBase> builder)
        {
            builder.HasKey(p => p.EntityId);
            builder.Property(p => p.EntityId).ValueGeneratedOnAdd();
            

        }
    }
}
