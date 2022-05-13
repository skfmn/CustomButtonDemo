using System;
using Xamarin.Forms;

namespace CustomButtonDemo
{

    public class CustomButton : Button
    {
        public CustomButton() {}

        public new static readonly BindableProperty PaddingProperty = BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(CustomButton), (Thickness)0);

        // Gets or sets Padding value
        public new Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }
    }
}