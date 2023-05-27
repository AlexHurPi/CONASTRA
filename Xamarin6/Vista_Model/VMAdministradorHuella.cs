using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin6.Vista_Model
{
    internal class VMAdministradorHuella:BaseViewModel
    {
        //-------------------------------------------------------------------------------
        #region VARIABLES
        string _Texto;
        #endregion
        //-------------------------------------------------------------------------------
        #region CONSTRUCTOR
        public VMAdministradorHuella(INavigation navigation)
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
        public async Task SensorHuella()
        {
            DisplayAlert("Alerta", "Verifique el sensor de huella", "Ok");
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        //-------------------------------------------------------------------------------
        #region COMANDOS
        public ICommand SensorHuellaCommand => new Command(async () => await SensorHuella());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
