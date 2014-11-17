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

        //Click counters
        int brick_clicks;

        //button for wood
        private void wood_btn_Click(object sender, RoutedEventArgs e)
        {
            wood_amount++;
            wood_counter.Content = wood_amount + " logs";
        }

        //button for bricks
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            brick_clicks++;
            brick_out_of_ten.Content = brick_clicks + "/10";
            if (brick_clicks % 10 == 0)
            {
                brick_amount++;
                brick_clicks = 0;
                brick_out_of_ten.Content = brick_clicks + "/10";
            }
            brick_counter.Content=brick_amount+" bricks";           
        }

        //button for steel
        private void steel_btn_Click(object sender, RoutedEventArgs e)
        {
            brick_clicks++;
            if (brick_clicks % 10 == 0)
            {
                brick_amount++;
            }
            brick_counter.Content = brick_amount + " bricks";       
        }
    }
}
