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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double screenWidth = System.Windows.SystemParameters.WorkArea.Width;
        private double screenHeight = System.Windows.SystemParameters.WorkArea.Width;
        public MainWindow()
        {

            InitializeComponent();
            

            
        }

        internal static void close()
        {
        //    throw new NotImplementedException();
        }

        private void lock_btn_Click(object sender, RoutedEventArgs e)
        {
            Lock_Screen lock_screen = new Lock_Screen();
            lock_screen.Show();
         
        }

        private void power_btn_Click(object sender, RoutedEventArgs e)
        {
            Close_Screen confirm_window = new Close_Screen();
            confirm_window.Show();
        }
    }
}
