using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMOlvidoContraseña:BaseViewModel
    {
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Texto;
		string _Usuario="";
		string _Cedula="";
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMOlvidoContraseña(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region OBJETOS
		public string Texto
		{
			get { return _Texto; }
			set { SetValue(ref _Texto, value); }
		}
		public string Usuario
		{
			get { return _Usuario; }
			set { SetValue(ref _Usuario, value); }
		}
		public string Cedula
		{
			get { return _Cedula; }
			set { SetValue(ref _Cedula, value); }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public async Task Volver()
		{
			await Navigation.PushAsync(new Autenticacion());
		}
		public async Task Restablecer()
		{
			if (Usuario == "" || Cedula == "")
			{
				DisplayAlert("Alert", "Verifique Usuario y Contraseña", "Ok");
			}
			else {DisplayAlert("Alert", "Contraseña restablecida y enviada a su correo", "Ok"); }
			
		}
		public void ProcesoSimple()
		{
			
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand VolverCommand => new Command(async () => await Volver());
		public ICommand RestablecerCommand => new Command(async () => await Restablecer());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
