using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Service.Interface
{
    public interface IMediaProvider
    {
        void PlayAudio(string filePath);
        void PlayDing();
        void PlayCompleted();
        void PlayWord(IWord word);

    }
}
