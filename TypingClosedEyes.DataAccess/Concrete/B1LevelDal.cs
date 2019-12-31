using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.DataAccess.EntityFramework;
using TypingClosedEyes.DataAccess.EntityFramework.Context;
using TypingClosedEyes.DataAccess.Interface;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.Concrete
{
    public class B1LevelDal : EfEntityRepositoryBase<B1Level,TceContext>, IB1LevelDal
    {
    }
}
