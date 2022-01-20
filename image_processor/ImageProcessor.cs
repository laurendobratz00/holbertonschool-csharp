using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;


///<summary> image processing </summary>
public class ImageProcessor
{
    ///<summary> a method that inverts an image’s color </summary>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach (filenames, file => {
            CreateInverse(file);
        });
    }
}

