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

        public static Bitmap GetImageMusic( string address,int width = 116, int height = 116)
        {
            try
            {
                using (TagLib.File file = TagLib.File.Create(address))
                {
                    using (var mStream = new System.IO.MemoryStream())
                    {
                        var firstPicture = file.Tag.Pictures.FirstOrDefault();
                        if (firstPicture != null)
                        {
                            byte[] pData = firstPicture.Data.Data;
                            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                            pData = null;
                            Bitmap bm = new Bitmap(mStream, false);

                            mStream.Dispose();

                            Bitmap bmImage = ResizeImage(bm, width, height);
                            bm.Dispose();
                            return bmImage;
                        }
                    }
                }
            }
            catch
            {
            }
            return null;
        }
    }
}
