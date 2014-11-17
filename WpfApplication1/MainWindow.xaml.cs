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
        public MainWindow()
        {
            InitializeComponent();
        }
        //Counters
        int wood_amount;
        int brick_amount;
        int steel_amount;
        //button for bricks
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            brick_amount++;
            brick_counter.Content=brick_amount+" bricks";           
        }
        //button for wood
        private void wood_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        //button for steel
        private void steel_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
