
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2RAD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }


        private async void listpagos__Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageLista());
        }

        private async void pay_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePagos());
        }
    }
}