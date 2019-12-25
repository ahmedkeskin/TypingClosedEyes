using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Abstract
{
    public abstract class LevelBase : ILevel
    {
        public string LevelCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EntityId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CompareTo([AllowNull] ILevel other)
        {
            throw new NotImplementedException();
        }
    }
}
