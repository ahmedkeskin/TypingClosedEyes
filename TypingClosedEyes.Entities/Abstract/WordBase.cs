using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Abstract
{
    public abstract class WordBase : IWord
    {
        public int WordId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WordText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FilePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EntityId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
