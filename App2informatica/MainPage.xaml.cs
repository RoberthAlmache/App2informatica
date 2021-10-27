using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2informatica
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario = "roberth", string contraseña = "123")
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblContraseña.Text = contraseña;
        }


        private void BtnCalProm_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Almacenar variables, lo que el usuario ingresa en la caja de texto
                double valor1 = Convert.ToDouble(txtPorEP.Text);
                double valor2 = Convert.ToDouble(txtPorEF.Text);

                //operacion
                double promF = valor1 + valor2;
                txtNF.Text = promF.ToString();


                if (promF > 7)
                {
                    txtEstado.Text = "APROBADO" ;
                }
                else
                {
                    if (promF > 5 && promF <= 6.999)
                    {
                        txtEstado.Text = "COMPLEMENTARIO";
                    }
                    else
                    {
                        txtEstado.Text = "REPROBADO";
                    }

                }
            }
            catch (Exception ex)
            {
                //mostrar error capturado de el bloque try
                DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }
        }

        private void btnCalPorEP_Clicked(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNS1.Text);
            double valor2 = Convert.ToDouble(txtNE1.Text);
            double v1 = short.Parse(txtNS1.Text);
            double v2 = short.Parse(txtNE1.Text);
            if (v1 < 0 || v1 > 10)
            {
                DisplayAlert("Error de entrada", "Solo puede ingresar numeros del 0 al 10", "Aceptar");
                txtNS1.Focus();
            }

            if (v2 < 0 || v2 > 10)
            {
                DisplayAlert("Error de entrada", "Solo puede ingresar numeros del 0 al 10", "Aceptar");
                txtNE1.Focus();
            }

            else

            {
                //operacion
                double suma1 = valor1 + valor2;
                txtEPresultado.Text = suma1.ToString();

                double suma2 = (valor1 * 0.3) + (valor2 * 0.2);
                txtPorEP.Text = suma2.ToString();

            }

        }


        private void btnCalPorEF_Clicked(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNS2.Text);
            double valor2 = Convert.ToDouble(txtNE2.Text);
          
            double v1 = short.Parse(txtNS2.Text);
            double v2 = short.Parse(txtNE2.Text);

            if (v1 < 0 || v1 > 10)
            {
                DisplayAlert("Error de entrada", "Solo puede ingresar numeros del 0 al 10", "Aceptar");
                txtNS2.Focus();
            }

            if (v2 < 0 || v2 > 10)
            {
                DisplayAlert("Error de entrada", "Solo puede ingresar numeros del 0 al 10", "Aceptar");
                txtNE2.Focus();
            }

            else

            {
                //operacion
                double suma1 = valor1 + valor2;
                txtEFresultado.Text = suma1.ToString();

                double suma2 = (valor1 * 0.3) + (valor2 * 0.2);
                txtPorEF.Text = suma2.ToString();
            }
        }
    }
}
