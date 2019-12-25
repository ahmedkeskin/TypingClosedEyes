using System;
using System.Collections.Generic;
using System.Text;

namespace TypingClosedEyes.Service.Interface
{
    public interface IWordProcessor
    {
        event EventHandler OnAfterValidate;
        event EventHandler OnBeforeValidate;
        bool IsContain(string text, string input);
        bool IsMatch(string text, string input);
    }
}
