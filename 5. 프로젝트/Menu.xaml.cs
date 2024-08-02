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
using System.Collections.Generic;
using JunhoProject.Models;
using System.Security.RightsManagement;
using System.Collections;

namespace JunhoProject
{
    /// <summary>
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    public partial class Menu : Page
    {
        public Menu()
        {
            int i;
            int num = 0;
            int sum = 0;
            int multiple = 0;
            InitializeComponent();
            if (list5.Count != 0)
            {
                List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

                User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
                userC.Name = "장바구니 항목";
                for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
                {
                    multiple = list3[i] * list4[i];
                    sum += multiple;
                }
                userC.UserAge = sum;
                for (i = 0; i < list4.Count; i++)
                {
                    num += list4[i];
                }
                userC.Count = num;
                userList1.Add(userC);

                for (i = 0; i < list1.Count; i++)           // 장바구니 항목에 대한 정보
                {
                    User userD = new User();
                    userD.UserImg = list1[i];
                    userD.Name = list2[i];
                    userD.UserAge = list3[i];
                    userD.Count = list4[i];
                    userList1.Add(userD);
                }
                listView_user.ItemsSource = userList1;      // 최종적으로 listView에 출력하기 위함

                sum = 0;
                for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
                {
                    multiple = list3[i] * list4[i];
                    sum += multiple;
                }
                myTextBlock.Text = ($"장바구니 가격: {sum}원");
            }
        }

        public static List<string> list1 = new List<string>();      // 이미지
        public static List<string> list2 = new List<string>();      // 이름
        public static List<int> list3 = new List<int>();            // 가격
        public static List<int> list4 = new List<int>();            // 수량
        public static List<string> list5 = new List<string>();      // 삭제 시 방금 누른 항목 삭제하기 위함

        private void btn_doSomeThing_Click(object sender, RoutedEventArgs e)    // '스위트콤보' 버튼
        {
            int i;
            int multiple = 0;
            int num = 0;
            int sum = 0;
            int nothing = 0;
            List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

            User userA = new User();                    // '현재 선택한 항목' 문구 출력을 하기 위함
            userA.Name = "현재 선택한 항목";
            userA.Count = 1;
            userList1.Add(userA);

            User userB = new User();                    // 현재 선택한 항목에 대한 정보
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\스위트콤보.png";
            userB.Name = "스위트콤보";
            userB.UserAge = 11000;
            userB.Count = 1;
            userList1.Add(userB);

            list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < list4.Count; i++)
            {
                num += list4[i];
            }
            userC.Count = num;
            userList1.Add(userC);

            for (i = 0; i < list1.Count; i++)           // 장바구니 항목에 대한 정보
            {
                User userD = new User();
                userD.UserImg = list1[i];
                userD.Name = list2[i];
                userD.UserAge = list3[i];
                userD.Count = list4[i];
                userList1.Add(userD);
            }

            for (i = 0; i < list1.Count; i++)
            {
                if (userB.Name == list2[i])
                {
                    list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (list1.Count == 0)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            if (nothing == list1.Count)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            listView_user.ItemsSource = userList1;      // 최종적으로 listView에 출력하기 위함
            sum = 0;
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            myTextBlock.Text = ($"장바구니 가격: {sum}원");

        }

        private void btn_doSomeThing1_Click(object sender, RoutedEventArgs e)   // '더블콤보' 버튼
        {
            int i;
            int multiple = 0;
            int num = 0;
            int sum = 0;
            int nothing = 0;
            List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

            User userA = new User();                    // '현재 선택한 항목' 문구 출력을 하기 위함
            userA.Name = "현재 선택한 항목";
            userA.Count = 1;
            userList1.Add(userA);

            User userB = new User();                    // 현재 선택한 항목에 대한 정보
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\더블콤보.png";
            userB.Name = "더블콤보";
            userB.UserAge = 15000;
            userB.Count = 1;
            userList1.Add(userB);

            list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < list4.Count; i++)
            {
                num += list4[i];
            }
            userC.Count = num;
            userList1.Add(userC);

            for (i = 0; i < list1.Count; i++)           // 장바구니 항목에 대한 정보
            {
                User userD = new User();
                userD.UserImg = list1[i];
                userD.Name = list2[i];
                userD.UserAge = list3[i];
                userD.Count = list4[i];
                userList1.Add(userD);
            }

            for (i = 0; i < list1.Count; i++)
            {
                if (userB.Name == list2[i])
                {
                    list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (list1.Count == 0)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            if (nothing == list1.Count)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            listView_user.ItemsSource = userList1;      // 최종적으로 listView에 출력하기 위함
            sum = 0;
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            myTextBlock.Text = ($"장바구니 가격: {sum}원");
        }

        private void btn_doSomeThing2_Click(object sender, RoutedEventArgs e)   //'반반팝콘' 버튼
        {
            int i;
            int multiple = 0;
            int num = 0;
            int sum = 0;
            int nothing = 0;
            List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

            User userA = new User();                    // '현재 선택한 항목' 문구 출력을 하기 위함
            userA.Name = "현재 선택한 항목";
            userA.Count = 1;
            userList1.Add(userA);

            User userB = new User();                    // 현재 선택한 항목에 대한 정보
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\반반팝콘.png";
            userB.Name = "반반팝콘";
            userB.UserAge = 7000;
            userB.Count = 1;
            userList1.Add(userB);

            list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < list4.Count; i++)
            {
                num += list4[i];
            }
            userC.Count = num;
            userList1.Add(userC);

            for (i = 0; i < list1.Count; i++)           // 장바구니 항목에 대한 정보
            {
                User userD = new User();
                userD.UserImg = list1[i];
                userD.Name = list2[i];
                userD.UserAge = list3[i];
                userD.Count = list4[i];
                userList1.Add(userD);
            }

            for (i = 0; i < list1.Count; i++)
            {
                if (userB.Name == list2[i])
                {
                    list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (list1.Count == 0)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            if (nothing == list1.Count)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            listView_user.ItemsSource = userList1;      // 최종적으로 listView에 출력하기 위함
            sum = 0;
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            myTextBlock.Text = ($"장바구니 가격: {sum}원");
        }

        private void btn_doSomeThing3_Click(object sender, RoutedEventArgs e) // '오리지널L' 버튼
        {
            int i;
            int multiple = 0;
            int num = 0;
            int sum = 0;
            int nothing = 0;
            List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

            User userA = new User();                    // '현재 선택한 항목' 문구 출력을 하기 위함
            userA.Name = "현재 선택한 항목";
            userA.Count = 1;
            userList1.Add(userA);

            User userB = new User();                    // 현재 선택한 항목에 대한 정보
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\오리지널L.png";
            userB.Name = "오리지널팝콘 L";
            userB.UserAge = 6000;
            userB.Count = 1;
            userList1.Add(userB);

            list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < list4.Count; i++)
            {
                num += list4[i];
            }
            userC.Count = num;
            userList1.Add(userC);

            for (i = 0; i < list1.Count; i++)           // 장바구니 항목에 대한 정보
            {
                User userD = new User();
                userD.UserImg = list1[i];
                userD.Name = list2[i];
                userD.UserAge = list3[i];
                userD.Count = list4[i];
                userList1.Add(userD);
            }

            for (i = 0; i < list1.Count; i++)
            {
                if (userB.Name == list2[i])
                {
                    list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (list1.Count == 0)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            if (nothing == list1.Count)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            listView_user.ItemsSource = userList1;      // 최종적으로 listView에 출력하기 위함
            sum = 0;
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            myTextBlock.Text = ($"장바구니 가격: {sum}원");
        }

        private void btn_doSomeThing5_Click(object sender, RoutedEventArgs e)   // '카라멜L' 버튼
        {
            int i;
            int multiple = 0;
            int num = 0;
            int sum = 0;
            int nothing = 0;
            List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

            User userA = new User();                    // '현재 선택한 항목' 문구 출력을 하기 위함
            userA.Name = "현재 선택한 항목";
            userA.Count = 1;
            userList1.Add(userA);

            User userB = new User();                    // 현재 선택한 항목에 대한 정보
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\카라멜L.png";
            userB.Name = "카라멜팝콘 L";
            userB.UserAge = 7000;
            userB.Count = 1;
            userList1.Add(userB);

            list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < list4.Count; i++)
            {
                num += list4[i];
            }
            userC.Count = num;
            userList1.Add(userC);

            for (i = 0; i < list1.Count; i++)           // 장바구니 항목에 대한 정보
            {
                User userD = new User();
                userD.UserImg = list1[i];
                userD.Name = list2[i];
                userD.UserAge = list3[i];
                userD.Count = list4[i];
                userList1.Add(userD);
            }

            for (i = 0; i < list1.Count; i++)
            {
                if (userB.Name == list2[i])
                {
                    list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (list1.Count == 0)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            if (nothing == list1.Count)
            {
                list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                list2.Add(userB.Name);
                list3.Add(userB.UserAge);
                list4.Add(userB.Count);
            }

            listView_user.ItemsSource = userList1;      // 최종적으로 listView에 출력하기 위함
            sum = 0;
            for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            myTextBlock.Text = ($"장바구니 가격: {sum}원");
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/Menu2.xaml", UriKind.Relative)
                            );
        }

        private void payment_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int multiple = 0;
            for (int i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = list3[i] * list4[i];
                sum += multiple;
            }
            if(sum > 0)
            {
                NavigationService.Navigate(
                    new Uri("/ShowBucket.xaml", UriKind.Relative)
                                );
            }
            else
            {
                MessageBox.Show("결제하실 상품이 없습니다.\n상품을 선택 후 결제 버튼을 눌러주세요.");
            }
        }

        private void before_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/Start.xaml", UriKind.Relative)
                            );
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            int i;
            int num = 0;
            int sum = 0;
            int multiple = 0;
            if (list5.Count != 0)
            {
                for (i = 0; i < list2.Count; i++)
                {
                    if (list5[list5.Count - 1] == list2[i] && list4[i] == 1)
                    {
                        list1.RemoveAt(i);
                        list2.RemoveAt(i);
                        list3.RemoveAt(i);
                        list4.RemoveAt(i);
                    }
                    else if (list5[list5.Count - 1] == list2[i] && list4[i] > 0)
                    {
                        list4[i] -= 1;
                    }
                }
                List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

                User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
                userC.Name = "장바구니 항목";
                for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
                {
                    multiple = list3[i] * list4[i];
                    sum += multiple;
                }
                userC.UserAge = sum;
                for (i = 0; i < list4.Count; i++)
                {
                    num += list4[i];
                }
                userC.Count = num;
                userList1.Add(userC);

                for (i = 0; i < list1.Count; i++)           // 장바구니 항목에 대한 정보
                {
                    User userD = new User();
                    userD.UserImg = list1[i];
                    userD.Name = list2[i];
                    userD.UserAge = list3[i];
                    userD.Count = list4[i];
                    userList1.Add(userD);
                }
                listView_user.ItemsSource = userList1;      // 최종적으로 listView에 출력하기 위함
                sum = 0;
                for (i = 0; i < list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
                {
                    multiple = list3[i] * list4[i];
                    sum += multiple;
                }
                myTextBlock.Text = ($"장바구니 가격: {sum}원");
                list5.RemoveAt(list5.Count - 1);
            }
        }
    }
}
