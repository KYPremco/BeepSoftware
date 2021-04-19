using System.Collections.Generic;

namespace Beep.Classes.Beep.Emotions
{
    public sealed class Neutral : BaseEmotion
    {
        protected override List<string> Gifs { get; }

        public Neutral()
        {
            Gifs = new List<string>();
            Gifs.Add("neutral_01");
            Gifs.Add("neutral_02");
            Gifs.Add("neutral_03");
        }
    }
}