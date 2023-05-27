using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMAuditoria1: BaseViewModel
    {
		//-------------------------------------------------------------------------------
		#region VARIABLES
		string _Texto;
		string _FechaInicial=string.Empty;
		string _FechaFinal=string.Empty;
		#endregion
		//-------------------------------------------------------------------------------
		#region CONSTRUCTOR
		public VMAuditoria1(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region OBJETOS
		public string FechaInicial
		{
			get { return _FechaInicial; }
			set { SetValue(ref _FechaInicial, value); }
		}
		public string FechaFinal
		{
			get { return _FechaFinal; }
			set { SetValue(ref _FechaFinal, value); }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public async Task Generar()
		{
			if(FechaInicial != string.Empty && FechaFinal!=string.Empty )
			{
				await Navigation.PushAsync(new AuditoriaInforme());
			}
			else { DisplayAlert("Atencion", "Ingrese fechas correctamente", "OK"); }
			
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
		public ICommand GenerarCommand => new Command(async () => await Generar());
		public ICommand VolverCommand => new Command(async () => await Volver());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
		#endregion
	}
}
