using Xamarin.Forms;

namespace AnimatedProgress.Core
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
