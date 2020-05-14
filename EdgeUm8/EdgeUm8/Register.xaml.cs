using EdgeUm8.Data;
using EdgeUm8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EdgeUm8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        User user = new User();
        UserDB userDB = new UserDB();
        public Register() {
            InitializeComponent();
            txtEmail.Focus();
            txtEmail.ReturnCommand = new Command(() => txtUserName.Focus());

            txtUserName.ReturnCommand = new Command(() => txtDesiredPassword.Focus());

            txtDesiredPassword.ReturnCommand = new Command(() => txtConfirmPassword.Focus());
        }
        private async void Register_Button_Clicked(object sender, EventArgs e) {
            if ((string.IsNullOrWhiteSpace(txtUserName.Text)) || (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(txtDesiredPassword.Text)) || (string.IsNullOrEmpty(txtUserName.Text)) || (string.IsNullOrEmpty(txtEmail.Text)) || (string.IsNullOrEmpty(txtDesiredPassword.Text))) {

                await DisplayAlert("Enter Data", "Enter Valid Data", "OK");

            } else if (!EmailValidation.ValidateEmail(txtEmail.Text)) {

                await DisplayAlert("e-Mail", "You have to enter a valid e-mail address with a @studentmail.oru.se domain", "OK");

            } else if (!PasswordValidation.ValidatePassword(txtDesiredPassword.Text)) {

                await DisplayAlert("Password", "Your password has to consist of at least 8 characters made up of at least 1 special, 1 numeric, 1 upper case and 1 lower case character.", "OK");

            } else if (!string.Equals(txtDesiredPassword.Text, txtConfirmPassword.Text)) {

                warningLabel.Text = "Enter Same Password";

                txtDesiredPassword.Text = string.Empty;

                txtConfirmPassword.Text = string.Empty;

                warningLabel.TextColor = Color.IndianRed;

                warningLabel.IsVisible = true;

            } else {

                user.Email = txtEmail.Text;

                user.UserName = txtUserName.Text;

                user.Password = txtDesiredPassword.Text;

                try {

                    var retrunvalue = userDB.AddUser(user);

                    if (retrunvalue == "User Sucessfully Registered!") {

                        await DisplayAlert("Registration", retrunvalue, "OK");

                        await Navigation.PushAsync(new Login());

                    } else {

                        await DisplayAlert("Registration", retrunvalue, "OK");

                        warningLabel.IsVisible = false;

                        txtEmail.Text = string.Empty;

                        txtUserName.Text = string.Empty;

                        txtDesiredPassword.Text = string.Empty;

                        txtConfirmPassword.Text = string.Empty;

                    }

                } catch (Exception ex) {

                    Debug.WriteLine(ex);

                }

            }
        }
    }
}