using ProyectoCatalogo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatalogo.InstanceLocator
{
	public class InstanceLocator
	{
		public InstanceLocator()
		{
			Menu = new MenuViewModel();
			ListPro = new ListProdutsViemModel();
            EditProduct = new EditProductViewModel();
        }

		public MenuViewModel Menu { get; set; }

		public ListProdutsViemModel ListPro { get; set; }

        public EditProductViewModel EditProduct { get; set; }
    }
}
