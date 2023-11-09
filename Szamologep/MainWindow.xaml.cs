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

namespace Szamologep
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		
		public MainWindow()
		{
			InitializeComponent();
			
		}
		public bool Ellenoriz()
		{
            if (tb_szam1.Text.Trim() !=null&& tb_szam2.Text.Trim() != null)
            {
                return true;
            }
            else
            {
				MessageBox.Show("Hibás adatok");
				return false;
            }
        }

		private void btn_plusz_Click(object sender, RoutedEventArgs e)
		{
            if (Ellenoriz() == true)
            {
				lb_eredmeny.Content = Convert.ToInt32(tb_szam1.Text.Trim())+ Convert.ToInt32(tb_szam2.Text.Trim()); 
			}
        }

		private void btn_minusz_Click(object sender, RoutedEventArgs e)
		{
			if (Ellenoriz() == true)
			{
				lb_eredmeny.Content = Convert.ToInt32(tb_szam1.Text.Trim()) - Convert.ToInt32(tb_szam2.Text.Trim());
			}
		}

		private void btn_szor_Click(object sender, RoutedEventArgs e)
		{
			if (Ellenoriz() == true)
			{
				lb_eredmeny.Content = Convert.ToInt32(tb_szam1.Text.Trim()) * Convert.ToInt32(tb_szam2.Text.Trim());
			}
		}

		private void btn_oszt_Click(object sender, RoutedEventArgs e)
		{
			if (Ellenoriz() == true)
			{
				double dogshit = (Convert.ToInt32(tb_szam1.Text.Trim()) / Convert.ToDouble(tb_szam2.Text.Trim()));
				lb_eredmeny.Content = Math.Round(dogshit,2);
			}
		}

		private void btn_maradek_Click(object sender, RoutedEventArgs e)
		{
			if (Ellenoriz() == true)
			{
				lb_eredmeny.Content = Convert.ToInt32(tb_szam1.Text.Trim()) % Convert.ToInt32(tb_szam2.Text.Trim());
			}
		}
	}
}
