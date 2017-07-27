using ProyectoCatalogo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoCatalogo.ViewModels
{
	public class ListProdutsViemModel : BaseViewModels
	{
		public ListProdutsViemModel()
		{
			
			ListProducts = new ObservableCollection<CatalogModel>();
			for (int i = 0; i < 20; i++)
			{
				CatalogModel ct = new CatalogModel();
				ct.id = i;
				ct.Nombre = string.Format("Nombre {0}", i);
				ct.Descripcion = string.Format("Description {0}", i);
				ListProducts.Add(ct);
			}
			//OnPropertyChanged("ListProducts");
		}

		private void GetSelectCatalog(CatalogModel obj)
		{
			
		}

		
		public ObservableCollection<CatalogModel> ListProducts { get; set; }
	}
}
