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
using Android.Provider;
using ZXing;
using Android.Graphics;
using System.IO;
using ZXing.Common;


namespace ScanCode
{
    /// <summary>
    /// 识别图片中的二维码
    /// </summary>
    [Activity(Label = "Recognize")]
    public class Recognize : Activity
    {
        private Button Broswer, RecognizeBtn;
        private ImageView Preview;
        private Android.Net.Uri img_path;
        private MultiFormatReader CodeReader;

        public const int BROSWER = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.Recognize);
            //设置
            CodeReader = new MultiFormatReader();

            Dictionary<DecodeHintType, object> hints = new Dictionary<DecodeHintType, object>();
            List<BarcodeFormat> SupFormats = new List<BarcodeFormat> {
                BarcodeFormat.All_1D,
                BarcodeFormat.QR_CODE
            };
            hints.Add(DecodeHintType.POSSIBLE_FORMATS,SupFormats);
            //hints.Add(DecodeHintType.CHARACTER_SET,"UTF-8");
            CodeReader.Hints = hints;

            
           
            


            Broswer = FindViewById<Button>(Resource.Id.Broswer);
            RecognizeBtn = FindViewById<Button>(Resource.Id.RecognizeBtn);
            Preview = FindViewById<ImageView>(Resource.Id.Preview);

            RecognizeBtn.Visibility = ViewStates.Invisible;
            Broswer.Click += Broswer_Click;

            RecognizeBtn.Click += RecognizeBtn_Click;
            // Create your application here
        }

        private void RecognizeBtn_Click(object sender, EventArgs e)
        {


            BitmapFactory.Options options = new BitmapFactory.Options();
            options.InJustDecodeBounds = true;
            Bitmap scanBitMap = BitmapFactory.DecodeFile(img_path.Path);
            options.InJustDecodeBounds = false;

            int sampleSize = options.OutHeight / 200;

            if (sampleSize <= 0)
                sampleSize = 1;

            options.InSampleSize = sampleSize;

            scanBitMap = BitmapFactory.DecodeFile(img_path.Path, options);
            LuminanceSource source = new BitmapLuminanceSource(scanBitMap);


            try
            {
                ZXing.Result res = CodeReader.decodeWithState(new BinaryBitmap(new HybridBinarizer(source)));

                if (res!=null&&!string.IsNullOrEmpty(res.Text))
                {
                    Toast.MakeText(this, res.Text, ToastLength.Long).Show();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
            }
                

            
        

        //图片浏览事件处理
        private void Broswer_Click(object sender, EventArgs e)
        {
            Intent innerIntent = new Intent(Intent.ActionPick,null);

            //if (Build.VERSION.SdkInt < BuildVersionCodes.Kitkat)
            //{
            //    innerIntent.SetAction(Intent.ActionGetContent);
            //}else
            //{
            //    innerIntent.SetAction(Intent.ActionOpenDocument);
            //}

            innerIntent.SetDataAndType(MediaStore.Images.Media.ExternalContentUri,"image/*");

            Intent wrapperIntent = Intent.CreateChooser(innerIntent,"选择条码图片");

            this.StartActivityForResult(innerIntent, BROSWER);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Android.App.Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            img_path = data.Data;
            if(resultCode == Android.App.Result.Ok)
            {
                switch (requestCode)
                {
                    case BROSWER:
                        {
                            var bm = MediaStore.Images.Media.GetBitmap(ContentResolver,data.Data);
                            RecognizeBtn.Visibility = ViewStates.Visible;
                            Preview.SetImageBitmap(bm);
                            Preview.SetAdjustViewBounds(true);
                        }
                        break;
                }
            }
        }


    }
}