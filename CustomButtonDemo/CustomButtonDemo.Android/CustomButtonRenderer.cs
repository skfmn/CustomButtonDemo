using Android.Content;
using Android.Util;
using Android.Views;
using CustomButtonDemo;
using CustomButtonDemo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace CustomButtonDemo.Droid
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context)
        { }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                return;
            }

            Control.SetPadding(0, 0, 0, 0);
            Control.SetPaddingRelative(0, 0, 0, 0);
            Control.SetIncludeFontPadding(false);
            Control.SetMinimumWidth(0);
            Control.SetMinWidth(0);
            Control.SetForegroundGravity(GravityFlags.Right);

            //When you set the height of the button in XAML and not the font size
            //this will set the font size to fit the height of the button
            Control.SetAutoSizeTextTypeUniformWithConfiguration(1, 50, 1, 0);

            


        }
    }
}