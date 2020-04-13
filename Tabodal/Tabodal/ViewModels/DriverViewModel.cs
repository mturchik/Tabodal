using System;

namespace Tabodal.ViewModels
{
    public class DriverViewModel : BaseViewModel
    {
        public DriverViewModel()
        {
            Title = "Can you drive?";
        }

        public string AgeInput { get; set; }
        private int SavedAge { get; set; }

        public bool AgeEntered
        {
            get
            {
                if (!decimal.TryParse(AgeInput, out var r))
                    return false;

                SavedAge = int.Parse(decimal.Floor(r).ToString());
                return true;
            }
        }

        public string CanDriveText
        {
            get
            {
                string result;
                if (!AgeEntered)
                    result = string.Empty;
                else if (SavedAge is 0)
                    result = string.Empty;
                else if (SavedAge < 16)
                    result = $"You're still dreaming! Wait another {Math.Abs(SavedAge - 16)} years!";
                else
                    result = $"You've been cruisin' for: {Math.Abs(SavedAge - 16)} years";

                return result;
            }
        }
    }
}