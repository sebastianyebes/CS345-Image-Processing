/* 
CEB IMAGE PROCESSING METHODS REPOSITORY
Copyright (C) 2022 Project - All Rights Reserved

CARL SEBASTIAN T. YEBES
yebes77@gmail.com
*/

using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessorLib
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

                    // Calculate formula for greyscale
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;

                    // Set pixel to the calculated one
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

                    // Calculate formula for inversion
                    int iR = 255 - pixel.R;
                    int iG = 255 - pixel.G;
                    int iB = 255 - pixel.B;

                    // Set pixel to the calculated one
                    Color inversion = Color.FromArgb(iR, iG, iB) ;    
                    processed.SetPixel(i, j, inversion);
                }
            }
        }

        public static void Sepia(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    Color pixel = loaded.GetPixel(i, j);
                    
                    // Calculate formula for sepia
                    int sR = (int)((0.393 * pixel.R) + (0.769 * pixel.G) + (0.189 * pixel.B));
                    int sG = (int)((0.349 * pixel.R) + (0.686 * pixel.G) + (0.168 * pixel.B));
                    int sB = (int)((0.272 * pixel.R) + (0.534 * pixel.G) + (0.131 * pixel.B));

                    // Check conditions
                    if (sR > 255)
                        sR = 255;
                    if (sG > 255)
                        sG = 255;
                    if (sB > 255)
                        sB = 255;

                    // Set pixel to the calculated one
                    Color sepia = Color.FromArgb(sR, sG, sB);
                    processed.SetPixel(i, j, sepia);
                }
            }
        }
    }
}
