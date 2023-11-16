using MVVM_implementacion_CARS.Vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_CARS_NEW.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        string _N1;
        string _N2;
        string _R;
        string _TipoUsuario;
        DateTime _selccionarTiempo;
        #endregion
        #region CONTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetValue(ref _TipoUsuario, value); }
        }
        public string SeleccionarTipoUsuario
        {
            get { return _TipoUsuario; }
            set
            {
                SetProperty(ref _TipoUsuario, value);
                TipoUsuario = _TipoUsuario;
            }
        }
        public DateTime tiemposeleccionado
        {
            get { return _selccionarTiempo; }
            set
            {
                _selccionarTiempo = value;
                OnpropertyChanged("tiemposeleccionado");
            }
        }
        #endregion
        #region PROCESOS

        public async Task Navegarpagina2()
        {
            await Navigation.PushAsync(new Page1());
        }
        public void tiempo()
        {
            tiemposeleccionado = DateTime.Now;
        } 
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(R);

            r = n1 + n2;
            R = r.ToString();
            //await DisplayAlert("titulo",Mensaje,"ok");
        }
        
        #endregion
        #region COMANDOS
        public ICommand Navegarpagina2command => new Command(async () => await Navegarpagina2());
        public ICommand Sumarcommand => new Command(Sumar);
        public ICommand tiempocommand => new Command(tiempo);

        #endregion
    }
}
