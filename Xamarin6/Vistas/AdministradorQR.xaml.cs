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
	public partial class AdministradorQR : ContentPage
	{
		public AdministradorQR()
		{
			InitializeComponent();
			BindingContext = new VMAdministradorQR(Navigation);
		}
	}
}