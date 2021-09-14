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
    public partial class ButtonLambdasPage : ContentPage
    {
        public ButtonLambdasPage()
        {
            this.BackgroundColor = Color.DarkKhaki;
            double number = 1;

            Label label = new Label
            {
                Text = number.ToString(),
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Double button
            Button doubleButton = new Button
            {
                Text = "Double",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            doubleButton.Clicked += (sender, args) =>
            {
                number *= 2;
                label.Text = number.ToString();
            };

            // Half button
            Button divideButton = new Button
            {
                Text = "Half",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            divideButton.Clicked += (sender, args) =>
            {
                number /= 2;
                label.Text = number.ToString();
            };

            // Assemble the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    label,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children =
                        {
                            doubleButton,
                            divideButton
                        }
                    }
                }
            };

        }
    }
}