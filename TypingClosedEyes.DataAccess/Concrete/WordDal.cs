using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TypingClosedEyes.DataAccess.EntityFramework;
using TypingClosedEyes.DataAccess.EntityFramework.Context;
using TypingClosedEyes.DataAccess.Interface;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.Concrete
{
    public class WordDal : EfEntityRepositoryBase<Word,TceContext>, IWordDal
    {

    }
}
