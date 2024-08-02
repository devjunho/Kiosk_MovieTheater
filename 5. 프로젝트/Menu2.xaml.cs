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
using System.Security.RightsManagement;
using System.Collections;

namespace JunhoProject
{
    /// <summary>
    /// Menu2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu2 : Page
    {
        int sum;
        public Menu2()
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
                for (i = 0; i < Menu.list4.Count; i++)
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
                num = 0;
                sum = 0;
                multiple = 0;
            }
        }

        private void btn_doSomeThing_Click(object sender, RoutedEventArgs e)    // '오리지널M' 버튼
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
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\오리지널M.png";
            userB.Name = "오리지널팝콘 M";
            userB.UserAge = 5000;
            userB.Count = 1;
            userList1.Add(userB);

            Menu.list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = Menu.list3[i] * Menu.list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < Menu.list4.Count; i++)
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

            for (i = 0; i < Menu.list1.Count; i++)
            {
                if (userB.Name == Menu.list2[i])
                {
                    Menu.list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (Menu.list1.Count == 0)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
            }

            if (nothing == Menu.list1.Count)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
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

        private void btn_doSomeThing1_Click(object sender, RoutedEventArgs e)   // '카라멜M' 버튼
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
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\카라멜M.png";
            userB.Name = "카라멜팝콘 M";
            userB.UserAge = 6000;
            userB.Count = 1;
            userList1.Add(userB);

            Menu.list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = Menu.list3[i] * Menu.list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < Menu.list4.Count; i++)
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

            for (i = 0; i < Menu.list1.Count; i++)
            {
                if (userB.Name == Menu.list2[i])
                {
                    Menu.list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (Menu.list1.Count == 0)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
            }

            if (nothing == Menu.list1.Count)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
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

        private void btn_doSomeThing2_Click(object sender, RoutedEventArgs e)   // '콜라M' 버튼
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
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\콜라M.png";
            userB.Name = "콜라 M";
            userB.UserAge = 3000;
            userB.Count = 1;
            userList1.Add(userB);

            Menu.list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = Menu.list3[i] * Menu.list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < Menu.list4.Count; i++)
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

            for (i = 0; i < Menu.list1.Count; i++)
            {
                if (userB.Name == Menu.list2[i])
                {
                    Menu.list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (Menu.list1.Count == 0)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
            }

            if (nothing == Menu.list1.Count)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
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

        private void btn_doSomeThing3_Click(object sender, RoutedEventArgs e)   // '콜라L' 버튼
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
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\콜라L.png";
            userB.Name = "콜라 L";
            userB.UserAge = 3500;
            userB.Count = 1;
            userList1.Add(userB);

            Menu.list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = Menu.list3[i] * Menu.list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < Menu.list4.Count; i++)
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

            for (i = 0; i < Menu.list1.Count; i++)
            {
                if (userB.Name == Menu.list2[i])
                {
                    Menu.list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (Menu.list1.Count == 0)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
            }

            if (nothing == Menu.list1.Count)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
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

        private void btn_doSomeThing4_Click(object sender, RoutedEventArgs e)   // '사이다M' 버튼
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
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\사이다M.png";
            userB.Name = "사이다 M";
            userB.UserAge = 3000;
            userB.Count = 1;
            userList1.Add(userB);

            Menu.list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = Menu.list3[i] * Menu.list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < Menu.list4.Count; i++)
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

            for (i = 0; i < Menu.list1.Count; i++)
            {
                if (userB.Name == Menu.list2[i])
                {
                    Menu.list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (Menu.list1.Count == 0)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
            }

            if (nothing == Menu.list1.Count)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
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

        private void btn_doSomeThing5_Click(object sender, RoutedEventArgs e)   // '사이다L' 버튼
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
            userB.UserImg = @"C:\Users\jhlee\OneDrive\바탕 화면\사진\사이다L.png";
            userB.Name = "사이다 L";
            userB.UserAge = 3500;
            userB.Count = 1;
            userList1.Add(userB);

            Menu.list5.Add(userB.Name);                      // 선택 이후, 삭제를 원할 때 방금 누른 항목 제거하기 위함

            User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
            userC.Name = "장바구니 항목";
            for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = Menu.list3[i] * Menu.list4[i];
                sum += multiple;
            }
            userC.UserAge = sum;
            for (i = 0; i < Menu.list4.Count; i++)
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

            for (i = 0; i < Menu.list1.Count; i++)
            {
                if (userB.Name == Menu.list2[i])
                {
                    Menu.list4[i] += 1;
                }
                else
                {
                    nothing++;
                }
            }

            if (Menu.list1.Count == 0)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
            }

            if (nothing == Menu.list1.Count)
            {
                Menu.list1.Add(userB.UserImg);                   // 현재 선택한 항목을 장바구니에 넣음
                Menu.list2.Add(userB.Name);
                Menu.list3.Add(userB.UserAge);
                Menu.list4.Add(userB.Count);
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

        private void before_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/Menu.xaml", UriKind.Relative)
                            );
        }

        private void payment_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int multiple = 0;
            for (int i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
            {
                multiple = Menu.list3[i] * Menu.list4[i];
                sum += multiple;
            }
            if (sum > 0)
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

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            int i;
            int num = 0;
            int sum = 0;
            int multiple = 0;
            if (Menu.list5.Count != 0)
            {
                for (i = 0; i < Menu.list2.Count; i++)
                {
                    if (Menu.list5[Menu.list5.Count - 1] == Menu.list2[i] && Menu.list4[i] == 1)
                    {
                        Menu.list1.RemoveAt(i);
                        Menu.list2.RemoveAt(i);
                        Menu.list3.RemoveAt(i);
                        Menu.list4.RemoveAt(i);
                    }
                    else if (Menu.list5[Menu.list5.Count - 1] == Menu.list2[i] && Menu.list4[i] > 0)
                    {
                        Menu.list4[i] -= 1;
                    }
                }
                List<User> userList1 = new List<User>();    // listView에 들어갈 항목을 담기 위함

                User userC = new User();                    // '장바구니 항목' 문구 출력을 하기 위함
                userC.Name = "장바구니 항목";
                for (i = 0; i < Menu.list3.Count; i++)       // 현재 장바구니 상품들의 총 가격
                {
                    multiple = Menu.list3[i] * Menu.list4[i];
                    sum += multiple;
                }
                userC.UserAge = sum;
                for (i = 0; i < Menu.list4.Count; i++)
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
                Menu.list5.RemoveAt(Menu.list5.Count - 1);
            }
        }
    }
}
