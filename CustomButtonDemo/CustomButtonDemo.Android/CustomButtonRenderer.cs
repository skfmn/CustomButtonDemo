using Android.Content;
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
            Control.SetAutoSizeTextTypeUniformWithConfiguration(1, 20, 1, 1);
            Control.SetForegroundGravity(GravityFlags.Right);
            Control.SetMinimumWidth(0);
            Control.SetIncludeFontPadding(false);
            Control.SetMinWidth(0);
            Control.SetPaddingRelative(0, 0, 0, 0);
        }
    }
}