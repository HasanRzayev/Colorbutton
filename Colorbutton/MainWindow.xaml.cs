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

namespace Colorbutton
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> lazim=new List<string>();
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    lazim.Add(prop.Name);
            }
  
     
            Random random = new Random();
            SolidColorBrush brush =
                new SolidColorBrush(
                    Color.FromRgb(
                    (byte)random.Next(255),
                    (byte)random.Next(255),
                    (byte)random.Next(255)
                    ));
            (sender as Button).Background = brush;
            MessageBox.Show($"Content-----{(sender as Button).Content}  ");

        }

        private void button_1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
       
            (sender as Button).Visibility = Visibility.Hidden;
            string lazim = (sender as Button).Content.ToString();
            this.Title = lazim;
        }

       
    }
}
