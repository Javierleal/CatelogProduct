using ProyectoCatalogo.Models;
using ProyectoCatalogo.Service;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoCatalogo.ViewModels
{
	public class EditProductViewModel : BaseViewModels
	{
		public EditProductViewModel()
		{
			Catalog = new CatalogModel();
            SaveCatalogCommand = new Command(SaveCatalog);

        }

        private async void SaveCatalog(object obj)
        {
            ServiceCatalog Service = new ServiceCatalog();

            CatalogoProductos Producto = new CatalogoProductos();
            Producto.id = Catalog.id.ToString();
            Producto.Nombre = Catalog.Nombre;
            Producto.Descripcion = Catalog.Descripcion;
            Producto.Imagen = "";

            await Service.CrearCatalogo(Producto);
        }

        public CatalogModel Catalog { get; set; }

        public ICommand SaveCatalogCommand { get; set; }
    }
}
