using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using Android.Views.Animations;
using Android.Support.V4.Content.Res;

namespace ScanCode
{
    public class MyScanOverlayView : View
    {
        private Paint mPaint;
        private Paint linePaint;
        private Paint cornerPaint;
        private Canvas _canvas;
        private bool isfirst = true;
        private Rect scan_line;
        int tem_top, tem_bottom;

        /// <summary>
        /// //���ùսǿ�ȣ�����)
        /// </summary>
        public int cornerlen { get; set; }
        public Rect CenterRect { get; set; }//�����м�͸������
        public MyScanOverlayView(Context context,IAttributeSet attrs) : base(context,attrs)
        {
            mPaint = new Paint();
            CenterRect = new Rect();
            scan_line = new Rect();
        }

        public MyScanOverlayView(Context context) : this(context, null)
        {

        }
        public override void Draw(Canvas canvas)
        {
            _canvas = canvas;

            mPaint.Color = Color.Argb(100,0,0,0);
            mPaint.SetStyle(Paint.Style.Fill);
            mPaint.StrokeWidth = 300f;
            mPaint.Alpha = 100;

            if (CenterRect == null)
            {
                CenterRect = new Rect(0,0,0,0);
            }
            
            
            

            //��ȡ��Ļ���
            int w_d = _canvas.Width;
            int ht = _canvas.Height;
            int nh = GetNavHeight();
            int sh = GetStatusBarHeight();

            //������Ļ��С����͸�������λ��
            CenterRect.Left = (int)(w_d * 0.2);

            int len = w_d - CenterRect.Left * 2;
            CenterRect.Top = sh + nh + len / 2;
            CenterRect.Right = CenterRect.Left + len;
            CenterRect.Bottom = CenterRect.Top + len;

           //���ν���ʱ��ʼ��
            if (isfirst)
            {
                isfirst = false;
                tem_top = CenterRect.Top;
                tem_bottom = CenterRect.Bottom;
               
            }
           
             
            //�����Ϸ���Ӱ
            canvas.DrawRect(0,0,Width,CenterRect.Top,mPaint);
            //�����·���Ӱ
            canvas.DrawRect(0,CenterRect.Bottom,Width,Height,mPaint);
            //���������Ӱ
            canvas.DrawRect(0,CenterRect.Top,CenterRect.Left,CenterRect.Bottom,mPaint);
            //�����ұ���Ӱ
            canvas.DrawRect(CenterRect.Right,CenterRect.Top,Width,CenterRect.Bottom,mPaint);

            //��ʼ��͸�������ɫ�߿򻭱�
            linePaint = new Paint();
            linePaint.SetStyle(Paint.Style.Stroke);
            linePaint.StrokeWidth = 1;
            linePaint.Color = Color.White;

            int wd = CenterRect.Width();
            int h = CenterRect.Height();

            //�����ĸ��ߵİ�ɫ��
            canvas.DrawLine(CenterRect.Left, CenterRect.Top, CenterRect.Right, CenterRect.Top,linePaint);//��
            canvas.DrawLine(CenterRect.Right, CenterRect.Top, CenterRect.Right, CenterRect.Bottom, linePaint);//��
            canvas.DrawLine(CenterRect.Left,CenterRect.Bottom,CenterRect.Right,CenterRect.Bottom,linePaint);//��
            canvas.DrawLine(CenterRect.Left,CenterRect.Top,CenterRect.Left,CenterRect.Bottom,linePaint);//��

            //��ʼ���߽ǻ���
            cornerPaint = new Paint();
            cornerPaint.SetStyle(Paint.Style.Fill);
            cornerPaint.Color = Color.Green;
            cornerPaint.StrokeWidth = 12;

            if (cornerlen == 0) cornerlen = 75;
            int offset = (int)cornerPaint.StrokeWidth / 2;
            int offlen = cornerlen - offset;

            //�����ĸ��߽�

           
            //����
            canvas.DrawLine(CenterRect.Left ,CenterRect.Top + offset, CenterRect.Left + cornerlen,CenterRect.Top + offset, cornerPaint);
            canvas.DrawLine(CenterRect.Left + offset, CenterRect.Top + 1.5f * offset, CenterRect.Left + offset, CenterRect.Top + 1.5f * offset + cornerlen - cornerPaint.StrokeWidth,cornerPaint);

            //����
            canvas.DrawLine(CenterRect.Right - cornerlen,CenterRect.Top + offset,CenterRect.Right,CenterRect.Top + offset,cornerPaint);
            canvas.DrawLine(CenterRect.Right - offset, CenterRect.Top + 1.5f * offset, CenterRect.Right -offset, CenterRect.Top + 1.5f * offset + offlen, cornerPaint);


            //����
            canvas.DrawLine(CenterRect.Left,CenterRect.Bottom - offset,CenterRect.Left + cornerlen,CenterRect.Bottom - offset,cornerPaint);
            canvas.DrawLine(CenterRect.Left + offset, CenterRect.Bottom - cornerlen, CenterRect.Left + offset, CenterRect.Bottom - cornerPaint.StrokeWidth, cornerPaint);


            //����
            canvas.DrawLine(CenterRect.Right - cornerlen,CenterRect.Bottom - offset,CenterRect.Right,CenterRect.Bottom - offset,cornerPaint);
            canvas.DrawLine(CenterRect.Right - offset, CenterRect.Bottom - cornerlen, CenterRect.Right - offset, CenterRect.Bottom - offset, cornerPaint);

            tem_top += 4;
            if (tem_top >= tem_bottom)
            {
                tem_top = CenterRect.Top;
            }

            //canvas.DrawRect(CenterRect.Left,tem_top,CenterRect.Right,tem_top + 5,cornerPaint);
            //����ɨ����ͼƬ
            scan_line.Left = CenterRect.Left;
            scan_line.Top = tem_top;
            scan_line.Right = CenterRect.Right;
            scan_line.Bottom = tem_top + 15;
            canvas.DrawBitmap(((Android.Graphics.Drawables.BitmapDrawable)ResourcesCompat.GetDrawable(this.Resources,Resource.Drawable.a4n,null)).Bitmap,null,scan_line,cornerPaint);
            PostInvalidateDelayed(10,CenterRect.Left,CenterRect.Top,CenterRect.Right,CenterRect.Bottom);
            //canvas.Save();

            
            
         
            
        }


        /// <summary>
        /// ��ȡ�������߶�
        /// </summary>
        /// <returns></returns>
        public int GetNavHeight()
        {
            int id = Resources.GetIdentifier("navigation_bar_height", "dimen", "android");
            int nh = Resources.GetDimensionPixelSize(id);

            return nh;
        }

        /// <summary>
        /// ��ȡ״̬���߶�
        /// </summary>
        /// <returns></returns>
        public int GetStatusBarHeight()
        {
            int id = Resources.GetIdentifier("status_bar_height", "dimen", "android");
            int sh = Resources.GetDimensionPixelSize(id);
            return sh;
        }

   

    }
}
  