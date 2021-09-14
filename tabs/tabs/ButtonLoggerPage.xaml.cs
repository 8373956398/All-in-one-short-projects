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
    public partial class ButtonLoggerPage : ContentPage
    {

        StackLayout loggerLayout = new StackLayout();

        public ButtonLoggerPage()
        {
            this.BackgroundColor = Color.FromHex("#c7eaec");
            Button button = new Button
            {
                Text = "Log the Click Time"
            };
            button.Clicked += OnButtonClicked;

            Padding = new Thickness(5, Device.RuntimePlatform == Device.iOS ? 20 : 0, 5, 0);
            Content = new StackLayout
            {
                Children =
                {
                    button,
                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = loggerLayout
                    }
                }
            };
        }


        void OnButtonClicked(object sender, EventArgs args)
        {
            loggerLayout.Children.Add(new Label
            {
                Text = "Button clicked at " + DateTime.Now.ToString("T"),
                TextColor=Color.Black
            });
        }

    }
}