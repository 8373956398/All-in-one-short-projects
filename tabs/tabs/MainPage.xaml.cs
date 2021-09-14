using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tabs
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            Children.Add(new LogIn() { Title = "LogIn ", IconImageSource = "login.png" });
            Children.Add(new colorLoop() { Title = "colorLoop", IconImageSource = "paint.png" });
            Children.Add(new SizedBoxViewPage() { Title = "SizedBoxView", IconImageSource = "box.png" });
            Children.Add(new FitToSizeClockPage() { Title = "ClockPage", IconImageSource = "clock.png" });
            Children.Add(new ButtonLambdasPage() { Title = "Double/Half", IconImageSource = "dice.png" });
            Children.Add(new ButtonLoggerPage() { Title = "Button Logger", IconImageSource = "logger.png" });
        }
    }
}
