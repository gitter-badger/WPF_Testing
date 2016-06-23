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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Close_Screen : Window
    {
        public Close_Screen()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //if the "yes" button is pushed then the entire application is terminated

            Environment.Exit(0);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //close the confirm quit window and return to the MainWindow.

            this.Close();
        }
    }
}
