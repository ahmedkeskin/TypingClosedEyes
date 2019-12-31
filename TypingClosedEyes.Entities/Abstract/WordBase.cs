using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Concrete;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Abstract
{
    public abstract class WordBase : IWord
    {
        public int EntityId { get; set; }
        public string Text { get; set; }
        public LevelBase Level { get; set; }
        public GrammarBase Grammar { get; set; }
        public CategoryBase Category { get; set; }
    }
}
