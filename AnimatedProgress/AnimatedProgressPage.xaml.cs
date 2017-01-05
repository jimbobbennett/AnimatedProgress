using Xamarin.Forms;

namespace AnimatedProgress
{
   public partial class AnimatedProgressPage : ContentPage
   {
      public AnimatedProgressPage()
      {
         InitializeComponent();

         BindingContext = new ProgressViewModel();
      }
   }
}
