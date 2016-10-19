using System.Drawing;

namespace Playthrough2.UI
{
    public static class BitmapExtensions
    {
        public static Icon ToIcon(this Bitmap bitmap)
        {
            using (var tempBitmap = new Bitmap(bitmap))
            {
                tempBitmap.MakeTransparent(Color.Magenta);
                var icon = tempBitmap.GetHicon();
                return Icon.FromHandle(icon);
            }
        }
    }
}
