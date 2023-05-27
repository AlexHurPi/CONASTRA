using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMAdministrador0:BaseViewModel
    {
        //-------------------------------------------------------------------------------
        #region VARIABLES
        string _Texto;
        #endregion
        //-------------------------------------------------------------------------------
        #region CONSTRUCTOR
        public VMAdministrador0(INavigation navigation)
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
        public async Task AvanzarPagina()
        {
            await Navigation.PushAsync(new Administrador1());
            
        }
		public async Task Actualizar()
		{
			await Navigation.PushAsync(new AdministradorActualizar());
		}
		public async Task Volver()
		{
			await Navigation.PushAsync(new Autenticacion());
		}
		public async Task IrAuditoria()
		{
			await Navigation.PushAsync(new Auditoria1());
		}
		public void ProcesoSimple()
        {
			
		}
		public async Task IrAjustes1()
		{
			await Navigation.PushAsync(new Ajustes1());

		}
		#endregion
		//-------------------------------------------------------------------------------
		#region COMANDOS
		public ICommand AvanzarPaginaCommand => new Command(async () => await AvanzarPagina());
		public ICommand ActualizarCommand => new Command(async () => await Actualizar());
		public ICommand IrAjustes1Command => new Command(async () => await IrAjustes1());
		public ICommand VolverCommand => new Command(async () => await Volver());
		public ICommand IrAuditoriaCommand => new Command(async () => await IrAuditoria());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
