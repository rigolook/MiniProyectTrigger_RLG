using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculadoraMVVMTriggers_RLG.VistaModelo
{
    public class VMpatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        
        #endregion
        #region CONTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
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
        public async Task ProcesoAsyncrono()
        {

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