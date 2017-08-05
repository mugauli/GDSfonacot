using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;

namespace GDSfonacot.Helpers
{
    public class ImageHelper
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                Image returnImage = null;
                if (byteArrayIn == null) return null;
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    returnImage = Image.FromStream(ms);
                }
                return returnImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            //MemoryStream ms = new MemoryStream();
            try
            {
                //if (imageIn != null)
                //{

                //    //imageIn.Save(ms,ImageFormat.Jpeg);
                //    //return ms.ToArray();
                //    MemoryStream ms = new MemoryStream();
                //    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //    return ms.ToArray();
                //}
                //return null;
                if (imageIn != null)
                {
                    byte[] imageBytes;
                    Image image = imageIn;
                    MemoryStream ms = new MemoryStream();
                    
                        image.Save(ms, image.RawFormat);
                        imageBytes = new byte[ms.Length];
                        //Very Important    
                        imageBytes = ms.ToArray();
                        return ms.ToArray();
                }
                return null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static Image ObtenerImagenNoDisponible()
        {
            try { 
            Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream file = assembly.GetManifestResourceStream("Helpers.Imagenes.NoDisponible.jpg");
            return Image.FromStream(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
