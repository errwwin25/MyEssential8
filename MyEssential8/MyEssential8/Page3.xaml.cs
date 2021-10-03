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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            
            var device = DeviceInfo.Model;

           
            var manufacturer = DeviceInfo.Manufacturer;

            
            var deviceName = DeviceInfo.Name;

            
            var version = DeviceInfo.VersionString;

           
            var platform = DeviceInfo.Platform;

            if(platform == DevicePlatform.Android)
            {

            }
            
            var idiom = DeviceInfo.Idiom;

           
            var deviceType = DeviceInfo.DeviceType;

            LabelDeviceInfo.Text = $"{deviceName} {version} {platform}";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }     
    }
}
