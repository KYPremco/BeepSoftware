using System.Collections.Generic;
using Beep.Classes.Beep.Emotions;

namespace Beep.Classes.Beep
{
    public class Beep
    {
        public Health Health { get; }
        
        private Dictionary<Emotion, BaseEmotion> Emotions { get; set; }

        public Beep()
        {
            Health = new Health();
            Emotions = new Dictionary<Emotion, BaseEmotion>();
            Emotions.Add(Emotion.HAPPY, new Happy());
        }

        public BaseEmotion GetEmotion()
        {
            return Emotions[Emotion.HAPPY];
        }
            
            
    }
}