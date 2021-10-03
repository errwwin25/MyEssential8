using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyEssential8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page8 : ContentPage
    {
        public Page8()
        {
            InitializeComponent();
        }
        private void ButtonVibrate_Clicked(object sender, EventArgs e)
        {
            Vibration.Vibrate(TimeSpan.FromMilliseconds(SliderTime.Value));
        }
        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            Vibration.Cancel();
        }
    }
}