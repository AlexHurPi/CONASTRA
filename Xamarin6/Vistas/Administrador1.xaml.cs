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
	public partial class Administrador1 : ContentPage
	{
		public Administrador1 ()
		{
			InitializeComponent ();
            BindingContext = new VMAdministrador1(Navigation);
			

		}

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}