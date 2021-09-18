using System;
using System.Drawing;

class ImageProcessor
    {
        public static void Inverse(string[] filenames)
        {
            foreach (string filename in filenames)
            {
                string new_filename = filename.Split('.')[0] + "_inverse.jpg";
                Bitmap bmp = new Bitmap(filename);

                //get image dimension
                int width = bmp.Width;
                int height = bmp.Height;

                //negative
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        Color p = bmp.GetPixel(x, y);

                        //extract ARGB value from p
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        //find negative value
                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        //set new ARGB value in pixel
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }

                //save negative image
                bmp.Save(new_filename);
            }
        }
    }
