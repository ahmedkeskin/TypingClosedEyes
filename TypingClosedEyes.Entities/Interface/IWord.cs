using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Abstract;

namespace TypingClosedEyes.Entities.Interface
{
    public interface IWord : IEntity
    {
        string Text { get; set; } 
        LevelBase Level { get; set; }
        GrammarBase Grammar { get; set; }
        CategoryBase Category { get; set; }
    }
}
