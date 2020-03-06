using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bindingv2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Osoba o = new Osoba();

		public MainWindow()
		{
			InitializeComponent();

			DataContext = o;

			/*Binding stringKaLabeli = new Binding();
			stringKaLabeli.Source = o;
			stringKaLabeli.Path = new PropertyPath("Ime");
			stringKaLabeli.Mode = BindingMode.OneWay;

			BindingOperations.SetBinding(lblIme, Label.ContentProperty, stringKaLabeli);

			Binding stringKaTekstBoksu = new Binding();
			stringKaTekstBoksu.Source = o;
			stringKaTekstBoksu.Path = new PropertyPath("Ime");
			stringKaTekstBoksu.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
			BindingOperations.SetBinding(txtIme, TextBox.TextProperty, stringKaTekstBoksu);*/

		}


		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			this.BindingGroup.CommitEdit();

			//BindingOperations.GetBindingExpression(txtIme, TextBox.TextProperty).UpdateSource();
		}
	}

	public class Osoba
	{
		public string Ime { get; set; } = "asd";
		public string Prezime { get; set; }

		//Ovo iznad je kratka forma ovog koda :)
		private string ime2 = "Test";
		public string Ime2
		{
			get
			{
				return ime2;
			}
			set
			{
				ime2 = value;
			}
		}

		public override string ToString()
		{
			return $"{Prezime} {Ime}";
		}
	}
}
