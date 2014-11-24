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
        int wood_clicks;
        int brick_clicks;
        int steel_clicks;
        int total_clicks;

        //Houses
        static int[] Konni = new int[4];
        
        int house_amount;
        //Areas
        //button for wood
        private void wood_btn_Click(object sender, RoutedEventArgs e)
        {
            house_curr_label.Content = house_amount;
            wood_clicks++;
            total_clicks++;
            wood_cap.Content = wood_clicks + "/10";
            if (wood_clicks % 10 == 0)
            {
                wood_amount++;
                wood_clicks = 0;
                wood_cap.Content = wood_clicks + "/10";
            }
            wood_counter.Content = wood_amount + " logs";
            
        }

        //button for bricks
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            house_curr_label.Content = house_amount;
            brick_clicks++;
            total_clicks++;
            brick_cap.Content = brick_clicks + "/10";
            if (brick_clicks % 10 == 0)
            {
                brick_amount++;
                brick_clicks = 0;
                brick_cap.Content = brick_clicks + "/10";
            }
            brick_counter.Content=brick_amount+" bricks";
            
        }

        //button for steel
        private void steel_btn_Click(object sender, RoutedEventArgs e)
        {
            
            house_curr_label.Content = house_amount;
            steel_clicks++;
            total_clicks++;
            steel_cap.Content = steel_clicks + "/10";
            if (steel_clicks % 10 == 0)
            {
                steel_amount++;
                steel_clicks = 0;
                steel_cap.Content = steel_clicks + "/10";
            }
            
            steel_counter.Content = steel_amount + " steel";
           
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            event_log.Items.Add("You just started, good for you!");
            makeHouse();
            house house1 = new house(Konni[0], Konni[1], Konni[2], Konni[3]);
            event_log.Items.Add("You need to build a house\n out of these materials\n" + house1);
            house_curr_label.Content = house1;

            
            
        }

        private void buy_house_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                buyHouse();
                
                
            }
            catch (canBuy)
            {

                event_log.Items.Add("error");
            }
            if (true)
            {

                
  
            }
            house_curr_label.Content = house_amount;
        }

        public void buyHouse()
        {
            if (steel_amount >= Konni[1] && wood_amount >= Konni[0] && brick_amount >= Konni[2])
            {
                steel_amount = steel_amount - Konni[1];
                steel_counter.Content = steel_amount + " steel";
                brick_amount = brick_amount - Konni[2];
                brick_counter.Content = brick_amount + " bricks";
                wood_amount = wood_amount - Konni[0];
                wood_counter.Content = wood_amount + " logs";
                house_amount++;
                event_log.Items.Add("You Bought a house");
                makeHouse();
                house house1 = new house(Konni[0], Konni[1], Konni[2], Konni[3]);
                event_log.Items.Add("You need to build a house\n out of these materials\n" + house1);
                house_curr_label.Content = house1;

                
            }
            else if (steel_amount <= Konni[1] && wood_amount <= Konni[0] && brick_amount <= Konni[2])
                throw new canBuy();
        }
        
        public int[] makeHouse()
        {
            Random rand = new Random();
            
            for (int i = 0; i < 4; i++)
            {
                Konni[i] = rand.Next(1, 60);
            }
           // 
            return Konni;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }
        
        
       

    }
}
