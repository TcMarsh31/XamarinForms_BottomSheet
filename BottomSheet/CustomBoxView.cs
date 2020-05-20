using System;
using Xamarin.Forms;

namespace BottomSheet
{
    public class CustomBoxView :BoxView
    {
        public CustomBoxView()
        {
        }

        public static readonly BindableProperty ShadowColorProperty = BindableProperty.Create(propertyName: "ShadowColor", returnType: typeof(Color), declaringType: typeof(CustomBoxView), defaultValue: Color.DarkGray);

        public Color ShadowColor {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly BindableProperty ShadowOpacityProperty = BindableProperty.Create(propertyName: "ShadowOpacity", returnType: typeof(float), declaringType: typeof(CustomBoxView), defaultValue: 0f);

        public float ShadowOpacity
        {
            get { return (float)GetValue(ShadowOpacityProperty); }
            set { SetValue(ShadowOpacityProperty, value); }
        }

        public static readonly BindableProperty ShadowRadiusProperty = BindableProperty.Create(propertyName: "ShadowRadius", returnType: typeof(float), declaringType: typeof(CustomBoxView), defaultValue: 0f);

        public float ShadowRadius
        {
            get { return (float)GetValue(ShadowRadiusProperty); }
            set { SetValue(ShadowRadiusProperty, value); }
        }

        public static readonly BindableProperty OffsetXProperty = BindableProperty.Create(propertyName: "OffsetX", returnType: typeof(int), declaringType: typeof(CustomBoxView), defaultValue: 0);

        public int OffsetX
        {
            get { return (int)GetValue(OffsetXProperty); }
            set { SetValue(OffsetXProperty, value); }
        }

        public static readonly BindableProperty OffsetYProperty = BindableProperty.Create(propertyName: "OffsetY", returnType: typeof(int), declaringType: typeof(CustomBoxView), defaultValue: 0);

        public int OffsetY
        {
            get { return (int)GetValue(OffsetYProperty); }
            set { SetValue(OffsetYProperty, value); }
        }

        /*public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(propertyName: "CornerRadius", returnType: typeof(float), declaringType: typeof(CustomBoxView), defaultValue: 0f);

        public float CornerRadius
        {
            get { return (float)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }*/

    }
}
