using JunhoProject.Models;
using System;
using System.Collections;
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
    /// finish.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class finish : Page
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public finish()
        {
            InitializeComponent();
            Menu.list1.Clear();                     // 장바구니 비우기
            Menu.list2.Clear();
            Menu.list3.Clear();
            Menu.list4.Clear();
            Menu.list5.Clear();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(3);
            dispatcherTimer.Tick += Timer_Tick;
            dispatcherTimer.Start();
        }

        public void Timer_Tick(object sender, System.EventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(
                new Uri("/Start.xaml", UriKind.Relative)
                            );
        }
    }
}
