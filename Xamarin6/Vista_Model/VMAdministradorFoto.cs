using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMAdministradorFoto: BaseViewModel
    {
        //-------------------------------------------------------------------------------
        #region VARIABLES
        string _Texto;
        StoreMediaOptions _FOTO;
        #endregion
        //-------------------------------------------------------------------------------
        #region CONSTRUCTOR
        public VMAdministradorFoto(INavigation navigation)
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
        public StoreMediaOptions FOTO
        {
            get { return _FOTO; }
            set { SetValue(ref _FOTO, value); }
        }
        #endregion
        //-------------------------------------------------------------------------------
        #region PROCESOS
        private  async Task  TomarFoto()
        {
            var camara = new StoreCameraMediaOptions();
            camara.PhotoSize = PhotoSize.Full;
            camara.SaveToAlbum = true;            
            
            var foto = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(camara);
            if (foto != null)
            {
                Foto = ImageSource.FromStream(() => { return foto.GetStream(); });
                
                VMAdministrador1 pasarFoto=new VMAdministrador1();
                pasarFoto.VisualizarFoto(Foto);            
            }
        }

		private async Task Volver()
        {
			await Navigation.PushAsync(new AdministradorActualizar2());
		}

		public async void ProcesoSimple()
        {
            
        }
        #endregion
        //-------------------------------------------------------------------------------
        #region COMANDOS
        public ICommand IrTomarFotoCommand => new Command(async () => await TomarFoto());
		public ICommand VolverCommand => new Command(async () => await Volver());
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
