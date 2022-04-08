using Examen2RAD.Controller;
using Examen2RAD.Model;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace Examen2RAD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePagos : ContentPage
    {
        Plugin.Media.Abstractions.MediaFile photo = null;
        
        public PagePagos()
        {
            InitializeComponent();
        }
       

       public async void btnfoto_Clicked(object sender, EventArgs e)
        {
             photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions

            {
                Directory = "FotosApp",
                Name = "test.jpg",
                SaveToAlbum= true,
            });
            if (photo!=null)
            {
                foto.Source = ImageSource.FromStream(() =>
                {
                    return photo.GetStream();
                });
            }
        }
        private byte[] CapturarImagen()
        {
            if (photo != null)
            {
                using (MemoryStream memory = new MemoryStream())
                {

                    Stream stream = photo.GetStream();
                    stream.CopyTo(memory);
                    return memory.ToArray();
                }
            }
            return null;
        }

        public async void agregar_Clicked(object sender, EventArgs e)


        {
            if (photo == null)
                return;
             var pagos = new Pagos()
            {
                Id_pago= Convert.ToInt32(codigo.Text),
                Descripcion = descip.Text,
                Monto = Convert.ToDouble(monto.Text),
                Phpto_recibo = CapturarImagen(),
                Fecha = fecha.Date,




            };
            await DataBase.Addpago(pagos);
            if (pagos != null)
            {
                await DisplayAlert("alerta", "guardado", "ok");
            }


        }
    }
}