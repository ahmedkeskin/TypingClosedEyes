using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Abstract;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.EntityFramework.Mapping
{
    public class A1LevelMap : IEntityTypeConfiguration<A1Level>
    {
        public void Configure(EntityTypeBuilder<A1Level> builder)
        {
            builder.HasBaseType<LevelBase>();
        }
    }
}
