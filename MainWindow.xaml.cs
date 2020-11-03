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
using System.Diagnostics;
using System.Windows.Threading;
using System.Windows.Forms;

namespace Spambot
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Timer
        DispatcherTimer dptimer = new DispatcherTimer();

        //Variablen
        string Spam_text;
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            dptimer.Tick += TimerLoop;
            dptimer.Interval = TimeSpan.FromMilliseconds(1);
           
           Spam_text = txt_spam.Text;
           dptimer.Start();
            
        }

        private void TimerLoop(object sender, EventArgs e)
        {
            SendKeys.SendWait(Spam_text);
            SendKeys.SendWait("{ENTER}");  
        }

        private void btn_start_stop_Click(object sender, RoutedEventArgs e)
        {
            dptimer.Stop();
            Spam_text = null;
            return;
        }
    }
}
