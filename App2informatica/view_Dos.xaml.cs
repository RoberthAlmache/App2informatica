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
    public partial class view_Dos : ContentPage
    {
        public view_Dos()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Almacenar variables, lo que el usuario ingresa en la cahja de texto
                double valor1 = Convert.ToDouble(txtValorUno.Text);               
                double valor2 = Convert.ToDouble(txtValorDos.Text);

                //operacion
                double suma = valor1 + valor2;
                txtResultado.Text = suma.ToString();

                double resta = valor1 - valor2;
                double multiplicacion = valor1 * valor2;
                double division = valor1 / valor2;

                txtResultado.Text = "SUMA=" + suma.ToString() + "RESTA=" + resta.ToString() + "MULTIPLICACION=" + multiplicacion.ToString() + "DIVISION=" + division.ToString();
            }
            catch (Exception ex)
            {
                //mostrar error capturado de el bloque try
                DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }

        }
    }
}