using System;
using System.Collections.Generic;
using System.Text;

namespace TypingClosedEyes.Entities.Interface
{
    public interface ICategory:IEntity
    {
        string CategoryName { get; set; }
    }
}
