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
    /// Interaction logic for Lock_Screen.xaml
    /// </summary>
    public partial class Lock_Screen : Window
    {
        public Lock_Screen()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Lock_Screen lock_screen = new Lock_Screen();
            lock_screen.Hide();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
          //  this.Close();
        }
    }
}
