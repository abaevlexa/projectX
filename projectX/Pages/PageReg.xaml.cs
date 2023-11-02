﻿using projectX.DB;
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

namespace projectX.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (DbConnect.entObj.User.Count(x => x.Name == TxbLog.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
                return;
            }
            else
            {
                try
                {
                    User userObj = new User()
                    {
                        IdRole = 2,
                        Name = TxbLog.Text,
                        Password = TxbPas.Text
                    };
                    DbConnect.entObj.User.Add(userObj);
                    DbConnect.entObj.SaveChanges();
                    MessageBox.Show("Пользователь создан",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(), "Критический сбой работы приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
