using System.Collections.Generic;

namespace Beep.Classes.Beep.Emotions
{
    public sealed class Happy : BaseEmotion
    {
        protected override List<string> Gifs { get; }

        public Happy()
        {
            Gifs = new List<string>();
            Gifs.Add("Happy_01");
            Gifs.Add("Happy_02");
            Gifs.Add("Happy_03");
        }
    }
}