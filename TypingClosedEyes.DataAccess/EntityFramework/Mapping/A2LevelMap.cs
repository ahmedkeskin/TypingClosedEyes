using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Abstract;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.EntityFramework.Mapping
{
    public class A2LevelMap : IEntityTypeConfiguration<A2Level>
    {
        public void Configure(EntityTypeBuilder<A2Level> builder)
        {
            builder.HasBaseType<LevelBase>();
        }
    }
}
