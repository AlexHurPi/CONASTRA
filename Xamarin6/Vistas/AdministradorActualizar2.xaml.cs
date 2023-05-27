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
	public partial class AdministradorActualizar2 : ContentPage
	{
		public AdministradorActualizar2()
		{
			InitializeComponent();
			BindingContext = new VMAdministradorActualizar2(Navigation);
		}
	}
}