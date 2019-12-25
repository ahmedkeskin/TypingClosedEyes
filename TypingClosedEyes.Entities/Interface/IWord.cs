using System;
using System.Collections.Generic;
using System.Text;

namespace TypingClosedEyes.Entities.Interface
{
    public interface IWord
    {
        public int WordId { get; set; }
        public string WordText { get; set; } 
        public string FilePath { get; set; }
    }
}
