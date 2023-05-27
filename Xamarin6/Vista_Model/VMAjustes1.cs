using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMAjustes1:BaseViewModel
    {
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Texto;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMAjustes1(INavigation navigation)
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
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public async Task IrPermisosAdmin()
		{
			await Navigation.PushAsync(new AdministradorActualizar());
		}
		public async Task Volver()
		{
			await Navigation.PushAsync(new Administrador0());
		}
		public async Task IrRestablecer()
		{
			await Navigation.PushAsync(new OlvidoContraseña());
		}
		public void ProcesoSimple()
		{
			
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand IrPermisosAdminCommand => new Command(async () => await IrPermisosAdmin());
		public ICommand IrRestablecerCommand => new Command(async () => await IrRestablecer());
		public ICommand VolverCommand => new Command(async () => await Volver());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
