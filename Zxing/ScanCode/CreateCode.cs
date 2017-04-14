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
using ZXing.Mobile;
using Android.Support.V4.App;
using Android.Provider;
using Android.Graphics;
using System.IO;

namespace ScanCode
{
    [Activity(Label = "CreateCode",ParentActivity =typeof(MainActivity),Icon ="@drawable/Icon")]
    public class CreateCode : Activity
    {
        private Button BarCodeGenerator, QCCodeGenerator;
        private ImageView Result;
        private TextView RawTxt;
        private BarcodeWriter bcw;
        private Bitmap bc;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActionBar.SetDisplayHomeAsUpEnabled(true);
            SetContentView(Resource.Layout.CreateCode);
            // Create your application here
            
            
            
            
            BarCodeGenerator = FindViewById<Button>(Resource.Id.BarCodeGenerator);
            QCCodeGenerator = FindViewById<Button>(Resource.Id.QCGenerator);
            Result = FindViewById<ImageView>(Resource.Id.Result);
            RawTxt = FindViewById<TextView>(Resource.Id.RawTxt);
            bcw = new BarcodeWriter();
            
            
            BarCodeGenerator.Click += (o, a) =>
            {

                bcw.Format = ZXing.BarcodeFormat.CODE_128;
                bcw.Options = new ZXing.Common.EncodingOptions
                {
                    Width = 400,
                    Height = 180
                };

                Result.SetPadding(0,10,0,10);
                Result.SetBackgroundColor(Android.Graphics.Color.White);

                
                if (!string.IsNullOrEmpty(RawTxt.Text)) {
                    bc = bcw.Write(ForceUtf8(RawTxt.Text.Trim()));
                    Result.SetImageBitmap(bc); 
                }
            };

            QCCodeGenerator.Click += (o, a) =>
            {
                bcw.Format = ZXing.BarcodeFormat.QR_CODE;
                bcw.Options = new ZXing.Common.EncodingOptions {
                    Width = 400,
                    Height = 400,
                    
                    
                };

                bcw.Options.Hints.Add(ZXing.EncodeHintType.CHARACTER_SET,"UTF-8");//���ñ����ַ���,�������Ļ�����
                if (!string.IsNullOrEmpty(RawTxt.Text))
                {
                    
                    bc = bcw.Write(RawTxt.Text);
                    
                    Result.SetImageBitmap(bc);
                    
                }
            };

            
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                //��ӦActionBar�� ����/home��ť
                case Android.Resource.Id.Home:
                    {
                        Intent upIntent = NavUtils.GetParentActivityIntent(this);

                        //��ǰActivity�����ڸ�Ӧ�õ�Taskʱ�������µ�TaskStack
                        if (NavUtils.ShouldUpRecreateTask(this, upIntent))
                        {
                            Android.App.TaskStackBuilder.Create(this)
                                .AddNextIntentWithParentStack(upIntent)//����ǰActivity�����õ�ParentActivityȫ�����뵽�´����� BackStack��
                                .StartActivities();//��ת����������Activity
                        }
                        else
                        {
                            NavUtils.NavigateUpTo(this, upIntent);
                            //NavUtils.NavigateUpFromSameTask(this);//������ǰ����Task�ǴӸ�Ӧ������ʱ��Ч
                        }

                       
                    }
                    break;
                case Resource.Id.action_compose:
                    {
                        SaveImg(bc,Guid.NewGuid().ToString()+".png");
                        Toast.MakeText(this,"�ɹ����浽���",ToastLength.Long).Show();
                    }
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        public bool SaveImg(Bitmap img,string filename)
        {
            string absoluatePath = System.IO.Path.Combine(FilesDir.Path, filename);//
            using (MemoryStream ms = new MemoryStream())
            {
                img.Compress(Bitmap.CompressFormat.Png,100,ms);
                byte[] data = ms.ToArray();
               
                using (FileStream fs = File.Open(absoluatePath,FileMode.Create))
                {
                   
                    fs.Write(data,0,data.Length);
                }
            }
            //����1
            //AddPicToGallery(absoluatePath);
            //����2,FilesDir·�������Ϊ ͸��ͼƬ�����񲻽�
            string thp = MediaStore.Images.Media.InsertImage(ContentResolver,absoluatePath,filename,"Demo");//��ͼ���в���һ��ͼƬ��������һ����������ͼ
            Console.WriteLine("����ͼ·����{0}",thp);

            AddPicToGallery(absoluatePath);
                return true;
        }

        /// <summary>
        /// ����ͼ�⣨���ַ�����Android�汾С��4.4 ʱ���ܻ��������)
        /// </summary>
        /// <param name="absoluatePath"></param>
        public void AddPicToGallery(string absoluatePath)
        {
            Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
            Java.IO.File file = new Java.IO.File(absoluatePath);
            mediaScanIntent.SetData(Android.Net.Uri.FromFile(file));
            
            this.SendBroadcast(mediaScanIntent);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Layout.menu,menu);
            
            return base.OnCreateOptionsMenu(menu);
        }

        public string ForceUtf8(string rawStr)
        {
            byte[] data = Encoding.UTF8.GetBytes(rawStr.ToCharArray());
           string s = Encoding.UTF8.GetString(data);
            return s;
        }

    }
}