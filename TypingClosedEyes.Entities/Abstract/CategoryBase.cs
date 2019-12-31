using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Abstract
{
    public abstract class CategoryBase : ICategory
    {
        public int EntityId { get; set; }
        public string CategoryName { get; set; }
        
    }
}
