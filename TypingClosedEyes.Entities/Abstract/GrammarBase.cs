using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Abstract
{
    public abstract class GrammarBase : IGrammar
    {
        public int EntityId { get; set; }
        public string TypeName { get; set; }

    }
}
