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
using Android.Util;
using Android.Graphics;

namespace ScanCode
{
    public class ScanView : LinearLayout
    {
        private Paint mPaint;
        private Paint linePaint;
        private Paint cornerPaint;

        /// <summary>
        /// //���ùսǿ�ȣ�����)
        /// </summary>
        public int cornerlen { get; set; }
        public Rect CenterRect { get; set; }//�����м�͸������
        public ScanView(Context context, IAttributeSet attrs) : base(context,attrs)
        {
            mPaint = new Paint();
           
        }

        public ScanView(Context context) : this(context, null)
        {
            
        }

        public override void Draw(Canvas canvas)
        {

            mPaint.Color = Color.Argb(100, 0, 0, 0);
            mPaint.SetStyle(Paint.Style.Fill);
            mPaint.StrokeWidth = 300f;
            mPaint.Alpha = 100;

            if (CenterRect == null)
            {
                CenterRect = new Rect(0, 0, 0, 0);
            }

            //�����Ϸ���Ӱ
            canvas.DrawRect(0, 0, Width, CenterRect.Top, mPaint);
            //�����·���Ӱ
            canvas.DrawRect(0, CenterRect.Bottom, Width, Height, mPaint);
            //���������Ӱ
            canvas.DrawRect(0, CenterRect.Top, CenterRect.Left, CenterRect.Bottom, mPaint);
            //�����ұ���Ӱ
            canvas.DrawRect(CenterRect.Right, CenterRect.Top, Width, CenterRect.Bottom, mPaint);

            //��ʼ��͸�������ɫ�߿򻭱�
            linePaint = new Paint();
            linePaint.SetStyle(Paint.Style.Stroke);
            linePaint.StrokeWidth = 1;
            linePaint.Color = Color.White;

            int wd = CenterRect.Width();
            int h = CenterRect.Height();

            //�����ĸ��ߵİ�ɫ��
            canvas.DrawLine(CenterRect.Left, CenterRect.Top, CenterRect.Right, CenterRect.Top, linePaint);//��
            canvas.DrawLine(CenterRect.Right, CenterRect.Top, CenterRect.Right, CenterRect.Bottom, linePaint);//��
            canvas.DrawLine(CenterRect.Left, CenterRect.Bottom, CenterRect.Right, CenterRect.Bottom, linePaint);//��
            canvas.DrawLine(CenterRect.Left, CenterRect.Top, CenterRect.Left, CenterRect.Bottom, linePaint);//��

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
            canvas.DrawLine(CenterRect.Left, CenterRect.Top + offset, CenterRect.Left + cornerlen, CenterRect.Top + offset, cornerPaint);
            canvas.DrawLine(CenterRect.Left + offset, CenterRect.Top + 1.5f * offset, CenterRect.Left + offset, CenterRect.Top + 1.5f * offset + cornerlen - cornerPaint.StrokeWidth, cornerPaint);

            //����
            canvas.DrawLine(CenterRect.Right - cornerlen, CenterRect.Top + offset, CenterRect.Right, CenterRect.Top + offset, cornerPaint);
            canvas.DrawLine(CenterRect.Right - offset, CenterRect.Top + 1.5f * offset, CenterRect.Right - offset, CenterRect.Top + 1.5f * offset + offlen, cornerPaint);


            //����
            canvas.DrawLine(CenterRect.Left, CenterRect.Bottom - offset, CenterRect.Left + cornerlen, CenterRect.Bottom - offset, cornerPaint);
            canvas.DrawLine(CenterRect.Left + offset, CenterRect.Bottom - cornerlen, CenterRect.Left + offset, CenterRect.Bottom - cornerPaint.StrokeWidth, cornerPaint);


            //����
            canvas.DrawLine(CenterRect.Right - cornerlen, CenterRect.Bottom - offset, CenterRect.Right, CenterRect.Bottom - offset, cornerPaint);
            canvas.DrawLine(CenterRect.Right - offset, CenterRect.Bottom - cornerlen, CenterRect.Right - offset, CenterRect.Bottom - offset, cornerPaint);

            canvas.Save();

           
        }

        public override void AddView(View child, int width, int height)
        {
            base.AddView(child, width, height);
        }


    }
}