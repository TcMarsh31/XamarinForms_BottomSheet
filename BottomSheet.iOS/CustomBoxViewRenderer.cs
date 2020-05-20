using System;
using System.Drawing;
using BottomSheet;
using BottomSheet.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(CustomBoxView),typeof(CustomBoxViewRenderer))]
namespace BottomSheet.iOS
{
    public class CustomBoxViewRenderer :BoxRenderer
    {
        public CustomBoxViewRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            try
            {
                var elem = (CustomBoxView)this.Element;
                if (elem != null)
                {
                    //this.Layer.CornerRadius = elem.CornerRadius;
                    //shadow
                    this.Layer.ShadowColor = elem.ShadowColor.ToCGColor();
                    this.Layer.ShadowOpacity = elem.ShadowOpacity;
                    this.Layer.ShadowRadius = elem.ShadowRadius;
                    this.Layer.ShadowOffset = new SizeF(elem.OffsetX, elem.OffsetY);//0,2
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
