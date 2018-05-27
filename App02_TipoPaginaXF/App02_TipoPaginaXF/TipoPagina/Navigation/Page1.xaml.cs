using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}


        private void btnIrPagina2(Object sender, EventArgs args)
        {
            //Mantem historico de navegação - porem tem de estar dentro de um navigation page
            Navigation.PushAsync(new App02_TipoPaginaXF.TipoPagina.Navigation.Page2());

            //Ex.
            //App.Current.MainPage = new NavigationPage(new Navigation.Page1());
        }

        private void btnIrModal(Object sender, EventArgs args)
        {
            //Mantem historico de navegação - porem tem de estar dentro de um navigation page
            Navigation.PushModalAsync(new App02_TipoPaginaXF.TipoPagina.Navigation.Modal());

            //Ex.
            //App.Current.MainPage = new NavigationPage(new Navigation.Page1());
        }
    }
}