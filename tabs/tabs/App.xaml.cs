using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabs
{
    public partial class App : Application
    {
        internal string DisplayLabelText;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
