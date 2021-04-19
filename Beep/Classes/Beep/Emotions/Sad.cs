using System.Collections.Generic;

namespace Beep.Classes.Beep.Emotions
{
    public sealed class Sad : BaseEmotion
    {
        protected override List<string> Gifs { get; }

        public Sad()
        {
            Gifs = new List<string>();
            Gifs.Add("sad_01");
            Gifs.Add("sad_02");
            Gifs.Add("sad_03");
        }
    }
}