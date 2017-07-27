using ProyectoCatalogo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoCatalogo.ViewModels
{
	public class MenuViewModel : BaseViewModels
	{
		public MenuViewModel()
		{
			NavigateCommand = new Command<string>(Navigate);
		}

		private void Navigate(string Page)
		{
			App.Master.IsPresented = false;
			switch (Page)
			{
				case "List":
					App.Navigator.Navigation.PopToRootAsync();
					break;
				case "Edit":
					App.Navigator.Navigation.PushAsync( new EditProductView());
					break;
				default:
					break;
			}
			
		}

		public ICommand NavigateCommand { get; set; }
	}
}
