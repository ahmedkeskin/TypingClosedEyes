using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Concrete
{
    public class Word : IWord
    {
        public string WordText { get; set; }
        public string EntityId { get; set; }
    }
}
