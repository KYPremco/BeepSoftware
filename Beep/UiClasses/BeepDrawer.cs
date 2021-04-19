using System;
using System.Net.Mime;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Beep.Classes.Beep.Emotions;
using WpfAnimatedGif;


namespace Beep.UiClasses
{
    public static class BeepDrawer
    {
        public static UIElement DrawEmotion(BaseEmotion emote)
        {
            Image image = new Image();
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(String.Format("Gifs/{0}.gif", emote.getRandomGif()), UriKind.Relative);
            bitmapImage.EndInit();
            ImageBehavior.SetAnimatedSource(image, bitmapImage);

            return image;
        }
    }
}