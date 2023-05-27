using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin6.Vista_Model;
using Xamarin6.Vistas;

namespace Xamarin6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage( new PaginaInicio());
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
