﻿using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.DataAccess.EntityFramework;
using TypingClosedEyes.DataAccess.EntityFramework.Context;
using TypingClosedEyes.DataAccess.Interface;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.Concrete
{
    public class B2LevelDal : EfEntityRepositoryBase<B2Level, TceContext>, IB2LevelDal
    {
    }
}
