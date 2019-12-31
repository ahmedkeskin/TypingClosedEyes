using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.DataAccess.EntityFramework;
using TypingClosedEyes.DataAccess.EntityFramework.Context;
using TypingClosedEyes.DataAccess.Interface;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.Concrete
{
    public class A2LevelDal:EfEntityRepositoryBase<A2Level,TceContext>, IA2LevelDal
    {
    }
}
