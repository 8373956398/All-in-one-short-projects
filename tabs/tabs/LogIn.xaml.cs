using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            this.BackgroundColor = Color.FromHex("#3b5998");
            var heading = new Label { Text = "Log In", TextColor = Color.Black, HorizontalOptions=LayoutOptions.Center, VerticalOptions=LayoutOptions.Center};
            var userentry = new Entry { Placeholder = "username", TextColor=Color.Black };
            var password = new Entry { Placeholder = "Password", IsPassword = true, TextColor=Color.Black };
            var loginbtn = new Button { Text = "Log in", TextColor = Color.Black, BackgroundColor = Color.White };
            loginbtn.Clicked += OnClicked;
            this.Content = new StackLayout
            {
                Padding = new Thickness(80),
                Children = { heading, userentry, password, loginbtn }
            };

             void OnClicked(object sender, EventArgs e)
            {
                DisplayAlert("Log in", "log in sucessfull", "ok");
            }
        }
    }
}