using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Service.Interface
{
    public interface IMediaManager
    {
        void PlayAudio(string filePath);
        void PlayDing();
        void PlayCompleted();
        void PlayWord(IWord word);

    }
}
