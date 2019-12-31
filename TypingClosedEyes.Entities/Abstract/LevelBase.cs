using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Abstract
{
    public abstract class LevelBase : ILevel
    {
        public int EntityId { get; set; }
        public string LevelCode { get; set; }

    }
}
