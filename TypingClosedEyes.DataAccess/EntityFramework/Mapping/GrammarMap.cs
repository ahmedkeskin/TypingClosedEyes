using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Abstract;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.EntityFramework.Mapping
{
    public class GrammarMap : IEntityTypeConfiguration<Grammar>
    {
        public void Configure(EntityTypeBuilder<Grammar> builder)
        {
            builder.HasBaseType<GrammarBase>();
        }
    }
}
