using System;
using System.Collections.Generic;
using System.Text;

namespace TypingClosedEyes.Entities.Interface
{
    public interface IGrammar : IEntity
    {
        string TypeName { get; set; }
    }
}
