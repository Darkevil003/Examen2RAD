using Examen2RAD.Controller;
using Examen2RAD.View;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2RAD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Db.conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Examen2.db3"));

            MainPage = new NavigationPage(new PagePrincipal());
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
