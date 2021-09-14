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
    public partial class FitToSizeClockPage : ContentPage
    {
        public FitToSizeClockPage()
        {
            this.BackgroundColor = Color.FromHex("#042d5b");

            Label clockLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor=Color.White
            };

            Content = clockLabel;

            SizeChanged += (object sender, EventArgs args) =>
            {
                if (this.Width > 0)
                    clockLabel.FontSize = this.Width / 6;
            };

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
                return true;
            });

        }
    }
}