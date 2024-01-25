using MiniProyecto4_RLG.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniProyecto4_RLG.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroGastos : ContentPage
    {
        public RegistroGastos()
        {
            InitializeComponent();
            BindingContext = new VMRegistroGastos(Navigation);
        }
    }
}