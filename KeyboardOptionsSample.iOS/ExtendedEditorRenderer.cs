using System;
using KeyboardOptionsSample;
using KeyboardOptionsSample.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedEditor), typeof(ExtendedEditorRenderer))]
namespace KeyboardOptionsSample.iOS
{
    public class ExtendedEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if(this.Control!= null)
             this.Control.InputAccessoryView = null;
        }
    }
}
