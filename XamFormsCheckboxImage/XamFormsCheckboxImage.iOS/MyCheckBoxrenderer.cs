using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamFormsCheckboxImage;
using XamFormsCheckboxImage.iOS;

[assembly: ExportRenderer(typeof(MyCheckBox), typeof(MyCheckBoxrenderer))]

namespace XamFormsCheckboxImage.iOS
{
   public class MyCheckBoxrenderer : CheckBoxRenderer
   {
      protected override void OnElementChanged(ElementChangedEventArgs<CheckBox> e)
      {
         base.OnElementChanged(e);

         Control.SetImage(UIImage.FromBundle("star_unchecked"), UIControlState.Normal);
         Control.SetImage(UIImage.FromBundle("star_checked"), UIControlState.Selected);

         Element.CheckedChanged += (s, ev) =>
         {
            Control.Selected = Element.IsChecked;
         };
      }
   }
}