using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Abstract
{
    public abstract class CategoryBase : ICategory
    {
        public string CategoryName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EntityId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
