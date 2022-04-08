using Examen2RAD.Controller;
using Examen2RAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Provider.MediaStore;

namespace Examen2RAD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLista : ContentPage
    {
        public PageLista()
        {
            InitializeComponent();
        }
       

       


        private void ListaPagos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection == null)
            {
                Model.Pagos pagos = (Model.Pagos)e.CurrentSelection.FirstOrDefault();
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ListaPagos.ItemsSource = await DataBase.listarPago();
        }

        private void editar_Clicked(object sender, EventArgs e)
        {

        }

        private async void eliminar_Clicked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var conte = item.CommandParameter as Pagos;
           
            var result = await DisplayAlert("Delete", $"Delete {conte.Descripcion} de la Base de datos", "YES", "NO");
            if (result)
            {
                await DataBase.Delregister(conte);
               

                ListaPagos.ItemsSource = await DataBase.listarPago();

            }
           
                
            



        }
    }
}