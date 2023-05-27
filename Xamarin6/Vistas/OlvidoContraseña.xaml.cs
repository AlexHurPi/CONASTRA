using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;
using Xamarin6.Vista_Model;

namespace Xamarin6.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OlvidoContraseña : ContentPage
	{
        public OlvidoContraseña ()
		{
			InitializeComponent ();
			BindingContext = new VMOlvidoContraseña(Navigation);
		}

        /*private void Restablecer(object sender, EventArgs e)
        {
            if (cedula.Text == "12345")
            {
                
            }
            else { Navigation.PushAsync(new NoSeEnvio()); }
        }*/
        private void Volver(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Autenticacion());
        }

        

        
    }
}