using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2informatica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Ventana que se ejecuta
            //MainPage = new view_Dos();
            MainPage = new NavigationPage  (new Login());
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
