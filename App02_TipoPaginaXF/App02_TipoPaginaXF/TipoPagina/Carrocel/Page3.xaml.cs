using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carrocel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}


        private void MudarPagina(Object sender, EventArgs args)
        {
            //Metodo convencional - nao mantem historico
            //App.Current.MainPage = new Navigation.Page1();

            //Metodo com navigationpage - mantem historico
            App.Current.MainPage = new NavigationPage(new Navigation.Page1()) { BarBackgroundColor = Color.BlueViolet, BarTextColor = Color.BlanchedAlmond };
        }

        private void Tab(Object sender, EventArgs args)
        {
            App.Current.MainPage = new Tabbed.Abas();
        }

        private void MasterDet(Object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
        }
    }
}