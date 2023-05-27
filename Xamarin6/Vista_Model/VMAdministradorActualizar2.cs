using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
	internal class VMAdministradorActualizar2:BaseViewModel
	{
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Texto;
		DateTime _Creation_Date;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMAdministradorActualizar2(INavigation navigation)
		{
			Navigation = navigation;
			HoraActual();
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region OBJETOS
		public string Texto
		{
			get { return _Texto; }
			set { SetValue(ref _Texto, value); }
		}
		public DateTime Creation_Date
		{
			get { return _Creation_Date; }
			set { SetValue(ref _Creation_Date, value); }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS

		public async Task IrAdministradorHuella()
		{
			await Navigation.PushAsync(new AdministradorHuella());
		}
		public async Task IrAdministradorFoto()
		{
			await Navigation.PushAsync(new AdministradorFoto());
		}
		public async Task HoraActual()
		{
			Creation_Date = DateTime.Now;
		}
		public async Task IrAdministradorQR()
		{
			await Navigation.PushAsync(new AdministradorQR());
		}
		public async Task Volver()
		{
			await Navigation.PushAsync(new AdministradorActualizar());
		}

		public async Task Guardar()
		{
			DisplayAlert("Alerta", "Cambios guardados", "Ok");
		}
		public void ProcesoSimple()
		{
			
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand IrAdminstradorHuellaCommand => new Command(async () => await IrAdministradorHuella());
		public ICommand IrAdminstradorFotoCommand => new Command(async () => await IrAdministradorFoto());
		public ICommand IrAdministradorQRCommand => new Command(async () => await IrAdministradorQR());
		public ICommand VolverCommand => new Command(async () => await Volver());
		public ICommand GuardarCommand => new Command(async () => await Guardar());

		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
