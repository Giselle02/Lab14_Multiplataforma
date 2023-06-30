using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LABORATORIO14C
{
    public partial class App : Application
    {
        public static string DatabasePath { get; internal set; }

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
