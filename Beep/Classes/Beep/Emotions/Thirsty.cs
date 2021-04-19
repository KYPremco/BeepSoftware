using System.Collections.Generic;

namespace Beep.Classes.Beep.Emotions
{
    public sealed class Thirsty : BaseEmotion
    {
        protected override List<string> Gifs { get; }

        public Thirsty()
        {
            Gifs = new List<string>();
            Gifs.Add("thirsty_01");
            Gifs.Add("thirsty_02");
            Gifs.Add("thirsty_03");
        }
    }
}