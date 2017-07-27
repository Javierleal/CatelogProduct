using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace ProyectoCatalogo.ViewModels
{
	public class BaseViewModels
	{
		public event PropertyChangedEventHandler PropertyChange;
		public void OnPropertyChanged([CallerMemberName]string propertyname = "") =>
			PropertyChange?.Invoke(this, new PropertyChangedEventArgs(propertyname));
	}
}
