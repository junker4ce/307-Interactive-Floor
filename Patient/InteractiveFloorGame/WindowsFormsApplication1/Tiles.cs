using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InteractiveFloorGame
{
    public class TileInfo
    {
        //public TileInfo()
        //{
        //}

        public static int distancePercent = 0;
        public static int sizePercent = 0;

        public bool on = true;
        public bool stepped = false;

        public Image image = null;
        
        public Size size = new Size(1,1);

        public Point location = new Point(1, 1);

        public Image get_image(Size size)
        {
            Image resized_image = null;
            if (image != null && size.Height > 0 && size.Width > 0)
            {
                Bitmap temp_bitmap = new Bitmap(image, size);
                resized_image = temp_bitmap;
            }
            return resized_image;
        }

        public Image image_resize(Size size, Image image)
        {
            if (!on && image != null && size.Height > 0 && size.Width > 0)
            {
                Bitmap resized_temp = new Bitmap(image, size);
                image = resized_temp;
            }

            return image;
        }
    }

    //public class Globals
    //{
    //    public static TileInfo[] tiles;


    //}

}
