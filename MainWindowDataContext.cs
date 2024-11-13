using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDesktop
{
	public class MainWindowDataContext : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private string _message = string.Empty;

		public string Message
		{
			get { return _message; }
			set {
				_message = value;
				OnPropertyChanged(nameof(Message));
			}
		}

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
