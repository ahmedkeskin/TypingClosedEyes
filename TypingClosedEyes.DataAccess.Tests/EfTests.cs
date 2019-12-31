using System;
using System.Collections.Generic;
using TypingClosedEyes.DataAccess.Concrete;
using TypingClosedEyes.DataAccess.EntityFramework.Context;
using TypingClosedEyes.Entities.Concrete;
using Xunit;

namespace TypingClosedEyes.DataAccess.Tests
{
    public class EfTests
    {
        public EfTests()
        {

        }

        [Fact]
        public void CodeFirstCreateDb()
        {
            var wordDal = new WordDal();
            var categoryDal = new CategoryDal();
            using (var dbContext = new TceContext())
            {
                var ensure = dbContext.Database.EnsureCreated();

                var grammer = new Grammar();
                grammer.TypeName = "Verb";

                var level = new A1Level();

                var category = new Category();
                category.CategoryName = "Casual";
                categoryDal.Add(category);

                var expected = new Word
                {
                    Text = "Go",
                    Category = category,
                    Level=level,
                    Grammar=grammer
                };
                var addedWord = wordDal.Add(expected);
                var getAddedWord = wordDal.Get(g => g.EntityId == expected.EntityId);
                Assert.Equal(expected.EntityId, getAddedWord.EntityId);
            }
        }
    }
}
