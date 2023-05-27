using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin6.Vista_Model;

namespace Xamarin6.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Autenticacion : ContentPage
	{
		public Autenticacion ()
		{
			InitializeComponent ();
            BindingContext = new VMAutenticacion(Navigation);
        }

        private void Volver(object sender, EventArgs e)
        {
            
        }

        private void Olvido_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OlvidoContraseña());
        }

        async void MostrarAlerta(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "¡Registro Exitoso!", "Ok");
        }

    }
}