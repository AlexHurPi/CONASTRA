using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin6.Vista_Model
{
	internal class VMAdministradorQR:BaseViewModel
	{
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Texto;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMAdministradorQR(INavigation navigation)
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
		public async Task SensorQR()
		{
			DisplayAlert("Mensaje", "¡Verifique Driver de la camara!", "Ok");
		}
		public void ProcesoSimple()
		{

		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand SensorQRCommand => new Command(async () => await SensorQR());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
