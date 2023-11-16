using MVVM_implementacion_CARS.Vistas;
using MVVM_implementacion_CARS_NEW.Modelo;
using MVVM_implementacion_CARS_NEW.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_CARS_NEW.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Picachu",
                    Icono = "https://i.ibb.co/8K80QsZ/pikachu.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "bullbasaur",
                    Icono = "https://i.ibb.co/WDz5pjY/bullbasaur.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "charmander",
                    Icono = "https://i.ibb.co/55xVT5F/charmander.png"
                }
            };
        }
        public void ProcesoSimple()
        {

        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;

            if (pagina.Contains("Picachu"))
            {
                await Navigation.PushAsync(new pagina1());
            }
            if (pagina.Contains("bullbasaur"))
            {
                await Navigation.PushAsync(new Page1());
            }
            if (pagina.Contains("charmander"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion
        #region COMANDOS
        //public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
