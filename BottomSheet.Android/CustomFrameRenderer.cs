using System;
using System;
using Android.Content;
using BottomSheet;
using BottomSheet.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace BottomSheet.Droid
{
    public class CustomFrameRenderer : Xamarin.Forms.Platform.Android.AppCompat.FrameRenderer
    {
        public CustomFrameRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            try
            {
                var elem = (CustomFrame)this.Element;
                if (elem != null)
                {
                    //shadow
                    CardElevation = 30f;
                    TranslationZ = 0;
                    SetZ(30f);
                    //

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

