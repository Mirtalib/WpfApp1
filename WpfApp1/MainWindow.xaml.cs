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

namespace WpfApp1
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

        private void btnColor1_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Random random = new Random();

            if (button is null)
                return;

            button.Background = new SolidColorBrush( Color.FromRgb(Convert.ToByte(random.Next(255)) , Convert.ToByte(random.Next(255)), Convert.ToByte(random.Next(255))));
            MessageBox.Show(button.Background.ToString());
        }

        private void btnColor1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            if (button is null)
                return;
            conteiner.Children.Remove(button);
            Title = button.Name;
        }
    }
}
