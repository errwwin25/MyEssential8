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
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
        }
        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Sms.ComposeAsync(new SmsMessage(EntryMessage.Text,
                EntryNumber.Text));
        }
    }
}