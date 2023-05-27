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
	public partial class User1 : ContentPage
	{
		public User1()
		{
			BindingContext = new VMUser1(Navigation);
			InitializeComponent();						
		}

		public User1(string nombre, string cedula, string fecha)
		{
			BindingContext = new VMUser1(Navigation, nombre, cedula, fecha);
			InitializeComponent();
		}
	}
}