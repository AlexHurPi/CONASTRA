using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMAdministradorHabilitar:BaseViewModel
    {
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Texto;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMAdministradorHabilitar(INavigation navigation)
		{
			Navigation = navigation;
			//Habilitar();
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region OBJETOS
		public string Texto
		{
			get { return _Texto; }
			set { SetValue(ref _Texto, value); }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public async Task Volver()
		{
			await Navigation.PushAsync(new AdministradorActualizar());
		}
		public async Task Habilitar()
		{
			Texto = "Deshabilitado";
		}
		public void ProcesoSimple()
		{
			
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS

		public ICommand VolverCommand => new Command(async () => await Volver());
		public ICommand HabilitarCommand => new Command(async () => await Habilitar());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
