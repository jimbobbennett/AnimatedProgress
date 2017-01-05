using System;
using System.ComponentModel;

namespace AnimatedProgress
{
   public class ProgressViewModel : INotifyPropertyChanged
   {
      private double _progressPercent;
      public string ProgressPercent
      {
         get { return _progressPercent.ToString(); }
         set
         {
            double doubleValue;
            double.TryParse(value, out doubleValue);

            if (_progressPercent == doubleValue) return;

            _progressPercent = Math.Max(0, Math.Min(doubleValue, 100));

            Progress = _progressPercent / 100;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ProgressPercent)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Progress)));
         }
      }

      public double Progress { get; private set; }

      public event PropertyChangedEventHandler PropertyChanged;
   }
}
