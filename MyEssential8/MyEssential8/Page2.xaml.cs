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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            SetBackground(Battery.ChargeLevel,
                Battery.State == BatteryState.Charging);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }
        void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
        SetBackground(e.ChargeLevel, e.State == BatteryState.Charging);
        }

        void SetBackground(double level, bool charging)
        {
            Color? color = null;
            var status = charging ? "Charging" : "Not charging";

            if (level > .5f)
            {
                color = Color.Cyan.MultiplyAlpha(level);
            }
            else if (level > .1f)
            {
                color = Color.Brown.MultiplyAlpha(1d - level);
            }
            else
            {
                color = Color.Pink.MultiplyAlpha(1d - level);                              
            }
            BackgroundColor = color.Value;
            LabelBatteryLevel.Text = status;
        }
    }
}