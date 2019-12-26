using System;
using System.Collections.Generic;
using System.Text;

namespace TypingClosedEyes.Entities.Interface
{
    public interface IWord : IEntity
    {
        int WordId { get; set; }
        string WordText { get; set; } 
        string FilePath { get; set; }
    }
}
