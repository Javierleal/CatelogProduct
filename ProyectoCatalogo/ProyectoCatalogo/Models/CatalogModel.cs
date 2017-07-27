using ProyectoCatalogo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoCatalogo.Models
{
	public class CatalogModel
	{

		public CatalogModel()
		{
			SelectCatalog = new Command<CatalogModel>(GetSelectCatalog);
		}

		private void GetSelectCatalog(CatalogModel obj)
		{
			App.Navigator.Navigation.PushAsync(new EditProductView());
		}

		public int id { get; set; }
		public string Nombre  { get; set; }
		public string Descripcion { get; set; }
		public DateTime Fecha { get; set; }
		public string Imagen { get; set; }

		public ICommand SelectCatalog { get; set; }
	}


}
