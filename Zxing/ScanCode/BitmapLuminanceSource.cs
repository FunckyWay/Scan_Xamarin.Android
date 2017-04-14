using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace ScanCode
{
    public class BitmapLuminanceSource : ZXing.LuminanceSource
    {
        private byte[] bitmapPixels;
        public BitmapLuminanceSource(int width, int height) : base(width, height)
        {
        }

        public BitmapLuminanceSource(Bitmap bitmap):this(bitmap.Width,bitmap.Height)
        {
            int[] data = new int[bitmap.Width*bitmap.Height];
            bitmapPixels = new byte[bitmap.Width*bitmap.Height];

            bitmap.GetPixels(data, 0, Width, 0, 0, Width, Height);

            for (int i = 0; i < data.Length; i++)
            {
                this.bitmapPixels[i] = (byte)data[i];
            }
        }
        public override byte[] Matrix
        {
           get
            {
                return bitmapPixels;
            }
        }
        public override byte[] getRow(int y, byte[] row)
        {
            Array.Copy(bitmapPixels,y*Width,row,0,Width);
            return row;
        }
    }
}