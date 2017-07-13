using System;
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

        public static BindableProperty AnimatedProgressAnimationTimeProperty =
           BindableProperty.CreateAttached("AnimatedProgressAnimationTime",
           typeof(int),
           typeof(ProgressBar),
           800,
           BindingMode.OneWay);

        public static BindableProperty AnimatedProgressEasingProperty =
           BindableProperty.CreateAttached("AnimatedProgressEasing",
           typeof(string),
           typeof(ProgressBar),
           default(string),
           BindingMode.OneWay);

        public static double GetAnimatedProgress(BindableObject target) => (double)target.GetValue(AnimatedProgressProperty);
        public static void SetAnimatedProgress(BindableObject target, double value) => target.SetValue(AnimatedProgressProperty, value);

        public static int GetAnimatedProgressAnimationTime(BindableObject target) => (int)target.GetValue(AnimatedProgressAnimationTimeProperty);
        public static void SetAnimatedProgressAnimationTime(BindableObject target, int value) => target.SetValue(AnimatedProgressAnimationTimeProperty, value);

        public static string GetAnimatedProgressEasing(BindableObject target) => (string)target.GetValue(AnimatedProgressEasingProperty);
        public static void SetAnimatedProgressEasing(BindableObject target, string value) => target.SetValue(AnimatedProgressEasingProperty, value);

        private static void ProgressBarProgressChanged(ProgressBar progressBar, double progress)
        {
            ViewExtensions.CancelAnimations(progressBar);

            var animationTime = GetAnimatedProgressAnimationTime(progressBar);
            var easingName = GetAnimatedProgressEasing(progressBar);

            progressBar.ProgressTo(progress, Convert.ToUInt32(Math.Max(0, animationTime)), GetEasing(easingName));
        }

        private static Easing GetEasing(string easingName)
        {
            if (easingName.ToUpper() == nameof(Easing.BounceIn).ToUpper())
                return Easing.BounceIn;
            if (easingName.ToUpper() == nameof(Easing.BounceOut).ToUpper())
                return Easing.BounceOut;
            if (easingName.ToUpper() == nameof(Easing.CubicIn).ToUpper())
                return Easing.CubicIn;
            if (easingName.ToUpper() == nameof(Easing.CubicOut).ToUpper())
                return Easing.CubicOut;
            if (easingName.ToUpper() == nameof(Easing.CubicInOut).ToUpper())
                return Easing.CubicInOut;
            if (easingName.ToUpper() == nameof(Easing.Linear).ToUpper())
                return Easing.Linear;
            if (easingName.ToUpper() == nameof(Easing.SinIn).ToUpper())
                return Easing.SinIn;
            if (easingName.ToUpper() == nameof(Easing.SinOut).ToUpper())
                return Easing.SinOut;
            if (easingName.ToUpper() == nameof(Easing.SinInOut).ToUpper())
                return Easing.SinInOut;
            if (easingName.ToUpper() == nameof(Easing.SpringIn).ToUpper())
                return Easing.SpringIn;
            if (easingName.ToUpper() == nameof(Easing.SpringOut).ToUpper())
                return Easing.SpringOut;

            return Easing.SinIn;
        }
    }
}
