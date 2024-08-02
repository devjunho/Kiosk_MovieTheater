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

namespace JunhoProject
{
    /// <summary>
    /// ChoicePay.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChoicePay : Page
    {
        public ChoicePay()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/PayCard.xaml", UriKind.Relative)
                            );
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/ShowBucket.xaml", UriKind.Relative)
                            );
        }

        private void samsungpay_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/PaySamApple.xaml", UriKind.Relative)
                            );
        }

        private void applepay_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/PaySamApple.xaml", UriKind.Relative)
                            );
        }

        private void coupon_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/PayCard.xaml", UriKind.Relative)
                            );
        }
    }
}
