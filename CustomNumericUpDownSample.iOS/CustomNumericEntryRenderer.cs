using CustomNumericUpDownSample;
using CustomNumericUpDownSample.iOS;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomNumericUpDownEntry), typeof(CustomNumericEntryRenderer))]
namespace CustomNumericUpDownSample.iOS
{
    public class CustomNumericEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}