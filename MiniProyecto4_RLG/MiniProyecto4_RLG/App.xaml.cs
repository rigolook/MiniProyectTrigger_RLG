using MiniProyecto4_RLG.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniProyecto4_RLG
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegistroGastos();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
