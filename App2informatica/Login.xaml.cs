using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2informatica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
          

        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //enviar datos como parametros y almacenar en variables
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            await Navigation.PushAsync(new MainPage(usuario, contraseña));

           
        }
    }
}