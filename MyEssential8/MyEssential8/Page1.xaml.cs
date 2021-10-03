using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace MyEssential8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private async void ButtonOn_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOnAsync();
        }
        private async void ButtonOff_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
        }
    }
}