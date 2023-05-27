using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMAutenticacion:BaseViewModel
    {
        //-------------------------------------------------------------------------------
        #region VARIABLES
        string _UAdmin="";
        string _PassAdmin="";
        #endregion
        //-------------------------------------------------------------------------------
        #region CONSTRUCTOR
        public VMAutenticacion(INavigation navigation)
        {
            Navigation = navigation;
        }
        
        #endregion
        //-------------------------------------------------------------------------------
        #region OBJETOS
        public string UAdmin
        {
            get { return _UAdmin; }
            set { SetValue(ref _UAdmin, value); }
        }
        public string PassAdmin
        {
            get { return _PassAdmin; }
            set { SetValue(ref _PassAdmin, value); }
        }
        #endregion
        //-------------------------------------------------------------------------------
        #region PROCESOS
        public async Task Volver()
        { 
            await Navigation.PushAsync(new PaginaInicio());
        }
        public async Task IrAdministrador1()
        {
            if (UAdmin.ToLower() == "alex"&& PassAdmin=="123")
            {
                await Navigation.PushAsync(new Administrador0());
            }
            else if (UAdmin.ToLower()=="pedro"&& PassAdmin=="456")
            {
                await Navigation.PushAsync(new User1());
            }
            else if(UAdmin == "" || PassAdmin == "") 
            { 
                await DisplayAlert("Mensaje", "Ingrese datos", "Ok"); 
            }

			else { await DisplayAlert("Mensaje", "Error de Usuario y Contraseña. ¡Verifique!", "Ok"); }
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        //-------------------------------------------------------------------------------
        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand IrAdmon1Command => new Command(async () => await IrAdministrador1());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
