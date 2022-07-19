using Android.Content;
using Android.Graphics.Drawables;
using CustomNumericUpDownSample;
using CustomNumericUpDownSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomNumericUpDownEntry), typeof(CustomNumericEntryRenderer))]
namespace CustomNumericUpDownSample.Droid
{
    public class CustomNumericEntryRenderer : EntryRenderer
    {
        public CustomNumericEntryRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}