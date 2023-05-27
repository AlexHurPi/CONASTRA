using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMUserCedula:BaseViewModel
    {
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _NCedula;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMUserCedula(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region OBJETOS
		public string NCedula
		{
			get { return _NCedula; }
			set { SetValue(ref _NCedula, value); }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public async Task Cedula()
		{
			if(NCedula==5544.ToString()) 
			{
				string nombre = "Alexander Hurtado";
				string cedula = "5544";
				string fecha=DateTime.Now.ToString();
				await Navigation.PushAsync(new User1(nombre, cedula, fecha));			
			}
			else if (NCedula == null)
			{
				DisplayAlert("Mensaje", "¡Digite un numero!", "Ok");
			}
			else
			{
				DisplayAlert("Mensaje", "¡Cedula no registrada!", "Ok");
			}			
		}
		public void ProcesoSimple()
		{

		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand CedulaCommand => new Command(async () => await Cedula());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
