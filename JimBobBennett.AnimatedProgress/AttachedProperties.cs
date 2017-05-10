using Xamarin.Forms;

namespace JimBobBennett.AnimatedProgress
{
   public static class AttachedProperties
   {
      public static BindableProperty AnimatedProgressProperty =
         BindableProperty.CreateAttached("AnimatedProgress",
         typeof(double),
         typeof(ProgressBar),
         0.0d,
         BindingMode.OneWay,
         propertyChanged: (b, o, n) => ProgressBarProgressChanged((ProgressBar)b, (double)n));

      private static void ProgressBarProgressChanged(ProgressBar progressBar, double progress)
      {
         ViewExtensions.CancelAnimations(progressBar);
         progressBar.ProgressTo((double)progress, 800, Easing.SinOut);
      }
   }
}
