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
using System.Windows.Threading;

namespace JunhoProject
{
    /// <summary>
    /// PaySamApple.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PaySamApple : Page
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public PaySamApple()
        {
            InitializeComponent();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(5);
            dispatcherTimer.Tick += Timer_Tick;
            dispatcherTimer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/ChoicePay.xaml", UriKind.Relative)
                            );
        }
        public void Timer_Tick(object sender, System.EventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(
                new Uri("/finish.xaml", UriKind.Relative)
                            );
        }
    }
}
