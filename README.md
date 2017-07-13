# AnimatedProgress
Animating a Xamarin Forms progress bar using attached properties.

This turns this:

![Boring unanimated progressbar](https://github.com/jimbobbennett/AnimatedProgress/blob/master/Progress.gif)

To this:

![Exciting animated progressbar](https://github.com/jimbobbennett/AnimatedProgress/blob/master/AnimatedProgress.gif)

This is available as a Nuget package:

To use it, add the attached property to a progress bar and bind to your view model:

```powershell
Install-Package JimBobBennett.AnimatedProgress
```

```xml
<?xml version="1.0" encoding="utf-8"?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:jbb="clr-namespace:JimBobBennett.AnimatedProgress;assembly=JimBobBennett.AnimatedProgress"
             x:Class="AnimatedProgress.Core.AnimatedProgressPage">
  <StackLayout Padding="20,100" Spacing="40">
    <ProgressBar jbb:AttachedProperties.AnimatedProgress="{Binding Progress}"
                 jbb:AttachedProperties.AnimatedProgressAnimationTime="1000"
                 jbb:AttachedProperties.AnimatedProgressEasing="BounceOut"/>
  </StackLayout>
</ContentPage>
```
There are three properties you can set:

`AnimatedProgress` is used to set the progress value to animate to.
`AnimatedProgressAnimationTime` is the time in milliseconds for the progress animation
`AnimatedProgressEasing` is the name of the easing function to use. This needs to match one of the static members on the `Xamarin.Forms.Easing` class, such as `SinIn` or `BounceOut`.
