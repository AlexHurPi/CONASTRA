using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMAjustes1PermAdmin: BaseViewModel
    {
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Texto;
		string _EntryNombre;
		string _Administrador;
		bool _SwitchOnCommand;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMAjustes1PermAdmin(INavigation navigation)
		{
			Navigation = navigation;
			EntryNombre= "Pedro Pataquiva";
		}
		
		#endregion
		//-------------------------------------------------------------------------------
		#region OBJETOS
		public string Administrador
		{
			get { return _Administrador; }
			set { SetValue(ref _Administrador, value); }
		}
		public bool SwitchOnCommand
		{
			get { return _SwitchOnCommand; }
			set
			{
				_SwitchOnCommand = value;
				OnPropertyChanged(); // Notifica que la propiedad ha cambiado

				// Ejecuta la acción deseada aquí según el estado del Switch
				if (_SwitchOnCommand && EntryNombre !=string.Empty)
				{
					// Realiza alguna acción cuando el Switch está activado
					Administrador = "Ahora es Administrador";
				}
				else
				{
					// Realiza alguna acción cuando el Switch está desactivado
					Administrador = string.Empty;
				}
			}
		}
		public string EntryNombre
		{
			get { return _EntryNombre; }
			set { SetValue(ref _EntryNombre, value) ; }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public async Task Guardar()
		{
			if (EntryNombre != "")
			{
				DisplayAlert("Alert", "Datos guardados", "Ok");
				EntryNombre = string.Empty;
				Administrador = string.Empty;
				SwitchOnCommand= false;
			}
			else
			{
				DisplayAlert("Alert", "El campo esta vacio", "Ok");
			}
			
		}
		public async Task Volver()
		{
			await Navigation.PushAsync(new Ajustes1());
		}
		public void ProcesoSimple()
		{
			
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand GuardarCommand => new Command(async () => await Guardar());
		public ICommand VolverCommand => new Command(async () => await Volver());
		//public ICommand SwitchOnCommand => new Command(async () => await SwitchOn());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
