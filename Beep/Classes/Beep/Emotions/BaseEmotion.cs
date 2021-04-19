using System;
using System.Collections.Generic;

namespace Beep.Classes.Beep.Emotions
{
    public abstract class BaseEmotion
    {
        protected abstract List<string> Gifs { get; }
        
        public string getRandomGif()
        {
            Random rnd = new Random();
            return Gifs[rnd.Next(0, Gifs.Count)];
        }
    }
}