using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo_1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void Button_Clicked(object sender, EventArgs e)
        {
            //Declarar nuestro Binding context

            var Personas = new Modelos.Libreta
            {
                nombre = tnombre.Text.Trim(),
                apellido = tapellido.Text.Trim(),
                edad = Convert.ToInt32(tedad.Text.Trim()),
                correo = tcorreo.Text.Trim()

            };

            //cp: Content Page
            var cpPersona = new Persona();

            cpPersona.BindingContext = Personas;

            await Navigation.PushModalAsync(cpPersona);
        }
    }
}
