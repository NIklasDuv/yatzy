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

namespace yatzy
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
        Score score = new Score();
        //dice[0] representerar tärning 1 osv.
        int[] dice = new int[5];
        int diceRollsLeft = 3;
        private void RollDiceBtn_Click(object sender, RoutedEventArgs e)
        {
            diceRollsLeft--;
            if (diceRollsLeft == 0)
            {
                rollDiceBtn.IsEnabled = false;
            }
            //kollar gränssnittet efter valda tärningar
            if (d1Box.IsChecked==true)
            {
                dice[0] = RollDice()[0];
            }
            if (d2Box.IsChecked == true)
            {
                dice[1] = RollDice()[1];
            }
            if (d3Box.IsChecked == true)
            {
                dice[2] = RollDice()[2];
            }
            if (d4Box.IsChecked == true)
            {
                dice[3] = RollDice()[3];
            }
            if (d5Box.IsChecked == true)
            {
                dice[4] = RollDice()[4];
            }
            UpdateUI();
        }
        public static int[] RollDice()
        {
            int[] rng = new int[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                rng[i] = random.Next(1, 6);
            }
            return rng;
        }
        public void UpdateUI()
        {
            d1.Content = dice[0];
            d2.Content = dice[1];
            d3.Content = dice[2];
            d4.Content = dice[3];
            d5.Content = dice[4];
        }
    }
}
