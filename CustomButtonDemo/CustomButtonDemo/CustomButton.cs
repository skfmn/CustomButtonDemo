using Xamarin.Forms;

namespace CustomButtonDemo
{

    public class CustomButton : Button
    {
        public CustomButton() {}

        public new static readonly BindableProperty PaddingProperty = BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(CustomButton), (Thickness)0);

        public new Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

        public static readonly BindableProperty VerticalContentAlignmentProperty = BindableProperty.Create(nameof(VerticalContentAlignment), typeof(TextAlignment), typeof(CustomButton), TextAlignment.Center);

        public TextAlignment VerticalContentAlignment
        {
            get { return (TextAlignment)GetValue(VerticalContentAlignmentProperty); }
            set { SetValue(VerticalContentAlignmentProperty, value); }
        }

        public static readonly BindableProperty HorizontalContentAlignmentProperty = BindableProperty.Create(nameof(HorizontalContentAlignment), typeof(TextAlignment), typeof(CustomButton), TextAlignment.Start);

        public TextAlignment HorizontalContentAlignment
        {
            get { return (TextAlignment)GetValue(HorizontalContentAlignmentProperty); }
            set { SetValue(HorizontalContentAlignmentProperty, value); }
        }
    }
}