using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabodal.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabodal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriverPage : ContentPage
    {
        public DriverPage()
        {
            InitializeComponent();
        }

        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            var vm = (DriverViewModel) BindingContext;

            if (vm.AgeEntered)
                CanDriveLabel.Text = vm.CanDriveText;

            CanDriveLabel.IsVisible = vm.AgeEntered;
        }
    }
}