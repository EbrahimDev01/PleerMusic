using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;






namespace PleerMusic.Utility.Image
{
    public static class ImageControl
    {

        public static Bitmap ResizeImage(Bitmap source, int width, int height)
        {

            if (source.Width == width && source.Height == height) return source;

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);


            result.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            using (var g = Graphics.FromImage(result))

                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(0, 0, source.Width, source.Height), GraphicsUnit.Pixel);

            return result;


        }

    }
}
