using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        public void MudarPagina1(Object sender, EventArgs args)
        {
            Detail = new Navigation.Page1();
            IsPresented = false;
        }


        public void MudarPagina2(Object sender, EventArgs args)
        {
            Detail = new  NavigationPage(new Carrocel.Page1());
            IsPresented = false;
        }

        public void MudarPagina3(Object sender, EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false;  //Faz menu voltar no android - pois foi feito com botão
        }
    }
}