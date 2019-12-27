using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.EntityFramework.Mapping
{
    public class WordMap : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.HasKey(t => t.EntityId);
        }
    }
}
