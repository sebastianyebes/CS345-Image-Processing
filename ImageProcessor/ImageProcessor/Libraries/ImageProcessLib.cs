using System.Drawing;

namespace ImageProcessor
{
    public class ImageProcessLib
    {
        public static void Greyscale(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            for(int i = 0; i < loaded.Width; i++)
            {
                for(int j = 0; j < loaded.Height; j++)
                {
                    Color pixel = loaded.GetPixel(i, j);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    Color greyscale = Color.FromArgb(grey, grey, grey);
                    processed.SetPixel(i, j, greyscale);
                }
            }
        }

        public static void Inversion(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    Color pixel = loaded.GetPixel(i, j);
                    Color inversion = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B) ;
                    processed.SetPixel(i, j, inversion);
                }
            }
        }
    }
}
