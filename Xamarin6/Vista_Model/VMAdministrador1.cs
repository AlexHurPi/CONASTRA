using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;
using System.Data;
using Xamarin.Forms.Xaml;

namespace Xamarin6.Vista_Model
{
    internal class VMAdministrador1 : BaseViewModel
    {
        //-------------------------------------------------------------------------------
        #region VARIABLES
        string _Texto;
        DateTime _Creation_Date;
        //VMAdministradorFoto _Foto;
        ImageSource Foto2;
        #endregion
        //-------------------------------------------------------------------------------
        #region CONSTRUCTOR
        public VMAdministrador1(INavigation navigation)
        {
            Navigation = navigation;
			HoraActual();
		}

        public VMAdministrador1()
        {
            
        }

        #endregion
        //-------------------------------------------------------------------------------
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public DateTime Creation_Date
        {
            get { return _Creation_Date; }
            set { SetValue(ref _Creation_Date, value); }
        }

        #endregion
        //-------------------------------------------------------------------------------
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PushAsync(new Administrador0());
        }
        public async Task IrAdministradorHuella()
        {
            await Navigation.PushAsync(new AdministradorHuella());
        }
        public async Task IrAdministradorFoto()
        {
            await Navigation.PushAsync(new AdministradorFoto());
        }
		public async Task IrAdministradorQR()
        {
			await Navigation.PushAsync(new AdministradorQR());
		}
		public void VisualizarFoto(ImageSource fotoTomada)
        {
            Foto2= fotoTomada;
        }

        public async Task Guardar()
        {
            DisplayAlert("Alerta", "Datos guardados", "Ok");
        }
			public async Task HoraActual()
        {
            Creation_Date = DateTime.Now;           
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        //-------------------------------------------------------------------------------
        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand IrAdminstradorHuellaCommand => new Command(async () => await IrAdministradorHuella());
        public ICommand IrAdminstradorFotoCommand => new Command(async () => await IrAdministradorFoto());
        public ICommand IrAdministradorQRCommand => new Command(async () => await IrAdministradorQR());
		public ICommand GuardarCommand => new Command(async () => await Guardar());
		
		#endregion
	}
}
