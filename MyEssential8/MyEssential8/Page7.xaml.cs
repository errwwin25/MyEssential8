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
    public partial class Page7 : ContentPage
    {
        public Page7()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var contact = await Contacts.PickContactAsync();
            if (contact == null)
                return;
            var info = new StringBuilder();
            var id = contact.Id;
            var namePrefix = contact.NamePrefix;
            var givenName = contact.GivenName;
            var middleName = contact.MiddleName;
            var familyName = contact.FamilyName;
            var nameSuffix = contact.NameSuffix;
            var displayName = contact.DisplayName;
            var phones = contact.Phones;
            var emails = contact.Emails;

            LabelInfo.Text = info.ToString();

        }
    }
}