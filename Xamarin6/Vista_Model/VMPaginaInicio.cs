using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    internal class VMPaginaInicio:BaseViewModel
    {
        //-------------------------------------------------------------------------------
        #region VARIABLES
        string _Texto;
        #endregion
        //-------------------------------------------------------------------------------
        #region CONSTRUCTOR
        public VMPaginaInicio(INavigation navigation)
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
        public void IrAutenticacion()
        {
           Navigation.PushAsync(new Autenticacion());
        }
        public void IrUser1()
        {
            Navigation.PushAsync(new User1());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        //-------------------------------------------------------------------------------
        #region COMANDOS
        //public ICommand AdministradorCommand => new Command(async () => await IrAutenticacion());
        public ICommand IrUser1Command => new Command(IrUser1);
        public ICommand AdministradorCommand => new Command(IrAutenticacion);
        #endregion
    }
}
