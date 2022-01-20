using System;
using System.Collections.Generic;

namespace ImageProcessor
{
    class ImageProcessor
    {
        public static void Inverse(string[] filenames)
        {
            if (ofdLoad.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image imgSource = Image.FromFile(ofdLoad.FileName);
                    picDisplay.Image = imgSource;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid image");
                }
            }
        }
    }
}

