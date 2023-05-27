using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin6.Vistas;

namespace Xamarin6.Vista_Model
{
    class VMUser1: BaseViewModel
    {
        //-------------------------------------------------------------------------------
        #region VARIABLES
        string _Cedula="";
        string _Nombre="";
        string _Fecha = "";
        #endregion
        //-------------------------------------------------------------------------------
        #region CONSTRUCTOR
        public VMUser1(INavigation navigation)
        {
            Navigation = navigation;           
        }

		public VMUser1(INavigation navigation, string nombre, string cedula, string fecha)
		{
			Navigation = navigation;
			DisplayAlert("Mensaje", "¡Usuario registrado con exito!", "Ok");
			Nombre = nombre;
			Cedula = cedula;
			Fecha = fecha;
		}
		public VMUser1()
        {
            
        }
      
        #endregion
        //-------------------------------------------------------------------------------
        #region OBJETOS
        public string Cedula
        {
            get { return _Cedula; }
            set { SetValue(ref _Cedula, value); }
        }
		public string Nombre
		{
			get { return _Nombre; }
			set { SetValue(ref _Nombre, value); }
		}
		public string Fecha
		{
			get { return _Fecha; }
			set { SetValue(ref _Fecha, value); }
		}
		#endregion
		//-------------------------------------------------------------------------------
		#region PROCESOS
		public void IrUserHuella()
        {
            Navigation.PushAsync(new UserHuella());
        }

        public void IrUserQR()
        {
            Navigation.PushAsync(new UserQR());
        }
		public void IrUserCedula()
		{
			Navigation.PushAsync(new UserCedula());
		}
        public void Guardar()
        {       
            if (Cedula != "")
            {
				DisplayAlert("Mensaje", "¡Registro almacenado!", "Ok");
				Cedula = "";
				Nombre = "";
				Fecha = "";
			}
            else { DisplayAlert("Mensaje", "¡Datos vacios!", "Ok"); }
		}
		public void Volver()
		{
			Navigation.PushAsync(new PaginaInicio());
		}
		public void ProcesoSimple()
        {
			
		}
        #endregion
        //-------------------------------------------------------------------------------
        #region COMANDOS
        public ICommand IrUserHuellaCommand => new Command(IrUserHuella);
        public ICommand IrUserQRCommand => new Command(IrUserQR);
		public ICommand IrUserCedulaCommand => new Command(IrUserCedula);
		public ICommand GuardarCommand => new Command(Guardar);
		public ICommand VolverCommand => new Command(Volver);
		public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
