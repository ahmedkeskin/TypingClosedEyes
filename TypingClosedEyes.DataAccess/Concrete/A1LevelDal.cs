using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.DataAccess.EntityFramework;
using TypingClosedEyes.DataAccess.EntityFramework.Context;
using TypingClosedEyes.DataAccess.Interface;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.Concrete
{
    public class A1LevelDal : EfEntityRepositoryBase<A1Level, TceContext>, IA1LevelDal
    {
    }
}
