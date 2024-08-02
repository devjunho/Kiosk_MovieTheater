using JunhoProject.Models;
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
    /// ShowBucket.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ShowBucket : Page
    {
        public ShowBucket()
        {
            int i;
            int num = 0;
            int sum = 0;
            int multiple = 0;
            InitializeComponent();
            if (Menu.list5.Count != 0)
            {
                List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

                User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
                userC.Name = "장바구니 항목";
                for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
                {
                    multiple = Menu.list3[i] * Menu.list4[i];
                    sum += multiple;
                }
                userC.UserAge = sum;
                for (i=0; i<Menu.list4.Count; i++)
                {
                    num += Menu.list4[i];
                }
                userC.Count = num;
                userList1.Add(userC);

                for (i = 0; i < Menu.list1.Count; i++)           // 장바구니 항목에 대한 정보
                {
                    User userD = new User();
                    userD.UserImg = Menu.list1[i];
                    userD.Name = Menu.list2[i];
                    userD.UserAge = Menu.list3[i];
                    userD.Count = Menu.list4[i];
                    userList1.Add(userD);
                }
                listView_user.ItemsSource = userList1;      // 최종적으로 listView에 출력하기 위함

                sum = 0;
                for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
                {
                    multiple = Menu.list3[i] * Menu.list4[i];
                    sum += multiple;
                }
                myTextBlock.Text = ($"장바구니 가격: {sum}원");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/Menu.xaml", UriKind.Relative)
                            );
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/ChoicePay.xaml", UriKind.Relative)
                            );
        }
    }
}
