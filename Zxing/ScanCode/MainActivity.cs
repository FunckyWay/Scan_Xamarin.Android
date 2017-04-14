using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ZXing.Mobile;
using System.Threading.Tasks;
using Android.Util;
using Android.Views.Animations;
using Android.Hardware.Camera2;
using Android.Graphics;

namespace ScanCode
{
    [Activity(Label = "ScanCode", MainLauncher = true,Icon  = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button Create_Btn, Recognize, scanBtn;
        MobileBarcodeScanner scaner;
        private CameraManager _cameraManager;
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

           

            _cameraManager = (CameraManager)GetSystemService(Context.CameraService);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            scanBtn = FindViewById<Button>(Resource.Id.MyButton);
            //MyScanOverlayView overlayView = FindViewById<MyScanOverlayView>(Resource.Id.OverlayView);
            //overlayView.CenterRect = GetReasonalRect();
            // Get our button from the layout resource,
            // and attach an event to it

            MobileBarcodeScanner.Initialize(Application);
            scaner = new MobileBarcodeScanner();
             
            
            //Rect clearArea = GetReasonalRect();
            //TranslateAnimation ta = new TranslateAnimation(0, 0, 0,400);
            //ta.RepeatMode = RepeatMode.Restart;
            //ta.RepeatCount = 100;
            //ta.Duration = (long)1000;
            //ta.FillAfter = false;

            
            //TextView tv = FindViewById<TextView>(Resource.Id.Info);
            //tv.Text = metrics.ToString();//density = 3,height = 1920,width = 1080
            //tv.Text = metrics.DensityDpi.ToString(); //xxhigh
            //tv.Text = metrics.ScaledDensity.ToString();//3

            



            scanBtn.Click += async delegate
            {
                //scaner.AutoFocus();
                scaner.UseCustomOverlay = true;
               
                MyScanOverlayView overlay = new MyScanOverlayView(this);

                
              
                //Rect clearArea = GetReasonalRect();
                //TranslateAnimation ta = new TranslateAnimation(clearArea.Left,clearArea.Left,clearArea.Top,clearArea.Bottom);
                //ta.RepeatMode = RepeatMode.Restart;
                //ta.Duration = (long)2.5;

                //ImageView iv = new ImageView(this);
                //iv.SetImageResource(Resource.Drawable.a4n);

                //iv.StartAnimation(ta);
                

                
                
                

                //overlay.CenterRect = clearArea;

                //scaner.CustomOverlay = overlay;
              
                scaner.CustomOverlay = LayoutInflater.FromContext(this).Inflate(Resource.Layout.scan, null);
                
                 
                
                var res = await scaner.Scan();

                HandleScanResult(res);
            };

            Create_Btn = FindViewById<Button>(Resource.Id.CreateCode);

            Create_Btn.Click += (o,a) => {
                Intent it = new Intent(this,typeof(CreateCode));
                this.StartActivity(it);
            };

            Recognize = FindViewById<Button>(Resource.Id.Recognize);

            Recognize.Click += (o, a) => {
                Intent it = new Intent(this,typeof(Recognize));
                this.StartActivity(it);
            };

        }
        
        /// <summary>
        /// 处理扫码结果
        /// </summary>
        /// <param name="result"></param>
        void HandleScanResult(ZXing.Result result)
        {
            string msg = "";

            if (result != null && !string.IsNullOrEmpty(result.Text))
                msg = "Found Barcode: " + result.Text;
            else
                msg = "Scanning Canceled!";

            this.RunOnUiThread(() => Toast.MakeText(this, msg, ToastLength.Short).Show());
        }

        public Rect GetReasonalRect()
        {
            Rect rec = new Rect();
            DisplayMetrics metrics = new DisplayMetrics();
            this.WindowManager.DefaultDisplay.GetRealMetrics(metrics);

            int nh = GetNavHeight();
            int sh = GetStatusBarHeight();
            
            rec.Left = (int)(metrics.WidthPixels * 0.2);

            int len = metrics.WidthPixels - rec.Left*2;
            rec.Top = sh + nh + len/2;
            rec.Right = rec.Left + len;
            rec.Bottom = rec.Top + len;

            Console.WriteLine("Wd:{0}---------H:{1}",rec.Width(),rec.Height());
            return rec;
        }

        public int GetNavHeight()
        {
            int id = Resources.GetIdentifier("navigation_bar_height","dimen","android");
            int nh = Resources.GetDimensionPixelSize(id);

            return nh;
        }
        
        public int GetStatusBarHeight()
        {
            int id = Resources.GetIdentifier("status_bar_height","dimen","android");
            int sh = Resources.GetDimensionPixelSize(id);
            return sh;
        }

        public class P_StateCallBack : CameraCaptureSession.StateCallback
        {
            public override void OnConfigured(CameraCaptureSession session)
            {
                
            }

            public override void OnConfigureFailed(CameraCaptureSession session)
            {
                //throw new NotImplementedException();
            }
        }

        public bool IsLoLLiPop()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop) return true;
            return false;
        }
    }
}

