using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Abstract;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.EntityFramework.Mapping
{
    public class B2LevelMap : IEntityTypeConfiguration<B2Level>
    {
        public void Configure(EntityTypeBuilder<B2Level> builder)
        {
            builder.HasBaseType<LevelBase>();
        }
    }
}
