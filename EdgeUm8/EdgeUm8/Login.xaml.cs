using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EdgeUm8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.InsertPageBefore(new Master(), this);
            //await Navigation.PopAsync();
            //Application.Current.MainPage = new Master();

            // ^ first test, funkar.. men.. blir problem med toolbaritem på mastern pga det inte är en nav-page (och jag tror mainpage måste vara new nav-page, men då blir de 2 nav-bars pga nav-page i master)

            Application.Current.MainPage = new Master();
            await Navigation.PushAsync(new NavigationPage(new Master()));
        }
    }
}