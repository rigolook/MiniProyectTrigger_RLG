using CalculadoraMVVMTriggers_RLG.VistaModelo;
using MiniProyecto4_RLG.Conexion;
using MiniProyecto4_RLG.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MiniProyecto4_RLG.VistaModelo
{
    public class VMRegistroGastos : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mgastos> _gastos;
        #endregion
        #region CONTRUCTOR
        public VMRegistroGastos(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mgastos> Gastos
        {
            get { return _gastos; }
            set
            {
                _gastos = value;
                OnPropertyChanged(nameof(Gastos));
            }
        }
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }


        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public VMRegistroGastos()
        {
            // Inicializar FirebaseService con las credenciales adecuadas
            var firebaseService = new FirebaseService("https://miniproyecto4rlg-default-rtdb.firebaseio.com/", "https://miniproyecto4rlg-default-rtdb.firebaseio.com/");
            Gastos = new ObservableCollection<Mgastos>();

            // Obtener gastos de Firebase y actualizar la colección
            firebaseService.ObtenerGastosAsync().ContinueWith(task =>
            {
                foreach (var gasto in task.Result)
                {
                    Gastos.Add(gasto);
                }
            });
        }
        public void normal()
        {

        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand normalcommand => new Command(normal);

        #endregion
    }
}
