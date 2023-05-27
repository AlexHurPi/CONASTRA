using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMAuditoriaInforme: BaseViewModel
    {
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Texto;
		string _LongText;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMAuditoriaInforme(INavigation navigation)
		{
			Navigation = navigation;
			WriteLongText();
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region OBJETOS
		public string LongText
		{
			get { return _LongText; }
			set { SetValue(ref _LongText, value); }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public async Task Volver()
		{
			await Navigation.PushAsync(new Auditoria1());
		}
		public void WriteLongText()
		{
			string textSample = "Pedro Pataquiva 21/05/2023 Hora Entrada: 07:30 Hora" +
				" Salida: 17:35";
			for (int i = 0; i < 30; i++)
			{
				LongText+= textSample;
			}			
		}
		
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand VolverCommand => new Command(async () => await Volver());
		
		#endregion
	}
}
