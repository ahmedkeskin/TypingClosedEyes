using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Service.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWordComposer
    {
        IWord GetWordByLevel(ILevel level);
        IWord GetWord();
        IWord GetWordByGrammar(IGrammar grammar);
        IWord GetWordByCategory(ICategory category);
        IEnumerable<IWord> GetListWord(int count,ILevel level, IGrammar grammar, ICategory category);

    }
}
