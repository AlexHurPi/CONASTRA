using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin6.Vista_Model
{
    class VMUserHuella: BaseViewModel
    {
        //-------------------------------------------------------------------------------
        #region VARIABLES
        string _Texto;
        #endregion
        //-------------------------------------------------------------------------------
        #region CONSTRUCTOR
        public VMUserHuella(INavigation navigation)
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
        public async Task ProcesoAsyncrono()
        {

        }

        public async Task Sensor()
        {
            DisplayAlert("Mensaje", "¡Verifique el sensor lector de huella!", "Ok");

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        //-------------------------------------------------------------------------------
        #region COMANDOS
        public ICommand ProcesoAsyncCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand SensorCommand => new Command(async () => await Sensor());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
