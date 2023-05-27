using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
	internal class VMAdministradorActualizar:BaseViewModel
	{
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Cedula;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMAdministradorActualizar(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region OBJETOS
		public string Cedula
		{
			get { return _Cedula; }
			set { SetValue(ref _Cedula, value); }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public async Task Buscar()
		{
			if(Cedula=="5544" ) 
			{
				DisplayAlert("Alerta", "Cedula encontrada", "Ok");
				await Navigation.PushAsync(new AdministradorActualizar2());
			}
			else if (Cedula == "5533")
			{
				DisplayAlert("Alerta", "Cedula encontrada", "Ok");
				await Navigation.PushAsync(new AdministradorHabilitar());

			}
			else if (Cedula == "5522")
			{
				DisplayAlert("Alerta", "Cedula encontrada", "Ok");
				await Navigation.PushAsync(new Ajustes1PermAdmin());				
			}
			else { DisplayAlert("Alerta", "Cedula No encontrada", "Ok"); }
		}

		public async Task Volver()
		{
			await Navigation.PushAsync(new Administrador0());
		}
		public void ProcesoSimple()
		{
			
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand BuscarCommand => new Command(async () => await Buscar());
		public ICommand VolverCommand => new Command(async () => await Volver());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
