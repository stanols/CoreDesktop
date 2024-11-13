using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace CoreDesktop
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private MainWindowDataContext _dataContext;

		public MainWindow()
		{
			InitializeComponent();

			_dataContext = new MainWindowDataContext();

			DataContext = _dataContext;
		}

		public void OnClearButtonClick(object sender, RoutedEventArgs e)
		{
			_dataContext.Message = string.Empty;
		}

		public void OnDisplayHelloWorldButtonClick(object sender, RoutedEventArgs e)
		{
			_dataContext.Message = "Hello, world!";
		}

		public void OnDisplayNetworkInfoButtonClick(object sender, RoutedEventArgs e)
		{
			var hostName = Dns.GetHostName();
			var hostEntry = Dns.GetHostEntry(hostName);
			var ipAddressEntry = hostEntry.AddressList.FirstOrDefault();
			var ipAddress = ipAddressEntry?.ToString();

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(hostName);
			stringBuilder.AppendLine(ipAddress);

			_dataContext.Message = stringBuilder.ToString();
		}
	}
}