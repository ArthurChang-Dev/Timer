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

namespace WPF_Learning_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool stop;
        public MainWindow()
        {
            stop = false;
            InitializeComponent();
        }

        private void handleStopTimer(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void handleSetTimer(object sender, RoutedEventArgs e)
        {
            var minuntes = Convert.ToInt32(countdownValue.Text);
            //timer.Content = string.Format($"{minuntes}:{minuntes}");
            //This is wrong, the Content will not udpate until this function over
            //So probably need to use async function to set the timer
            int seconds = 0;
            while (!stop && (minuntes > 0 || seconds > 0))
            {
                if(seconds == 0)
                {
                    --minuntes;
                    seconds = 60;
                }
                else
                {
                    --seconds;
                }
                timer.Content = string.Format($"{minuntes}:{seconds}");
                System.Threading.Thread.Sleep(1000);
            }
            return;
        }

        private void handleResetTimer(object sender, RoutedEventArgs e)
        {
            return;
        }
    }
}
