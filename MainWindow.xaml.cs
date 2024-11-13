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

namespace CoreDesktop
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public TextBlock TextBlock { get; set; }
		public string Message { get; set; }

		public MainWindow()
		{
			DataContext = this;
			TextBlock = new TextBlock();
			InitializeComponent();
		}

		public void OnButtonClick(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hello, Natashka-Kakashka!");
		}
	}
}