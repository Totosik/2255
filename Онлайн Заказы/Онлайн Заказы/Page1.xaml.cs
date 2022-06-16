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
using Онлайн_Заказы.Бд;

namespace Онлайн_Заказы
{
   
    public partial class Page1 : Page
    {
        user_userEntities connection = new user_userEntities();
        public Page1()
        {
            InitializeComponent();
        }

        private void Back_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Class1.mainpage);
        }

        private void Exit_Btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.Close();
        }

        private void Enter_Btn_Click(object sender, RoutedEventArgs e)
        {
            string personal_number = Login_TBox.Text;
            var InspectorList = connection.Клиенты.ToList();

            if (personal_number == "")
            {
                MessageBox.Show("Введите номер !");

            }
            else
            {

                var class2 = connection.Клиенты.Where(ins => ins.Телефон.ToString() == personal_number).FirstOrDefault();
                {
                    if (class2 != null)
                    {
                        class2.Телефон = class2.Телефон;
                        MessageBox.Show("Вход выполнен!");
                        NavigationService.Navigate(class2.protocol);
                    }
                    else
                    {
                        MessageBox.Show("Введены некорректные данные!!!");

                    }

                }
            }
        }
    }
}
