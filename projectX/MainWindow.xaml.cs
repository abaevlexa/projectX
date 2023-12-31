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

namespace projectX
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrmMain.Navigate(new Pages.PageAuto());
            DbConnect.entObj = new PRAKTIKAEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrmMain.GoBack();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы на начальной странице!");
            }
        }
    }
}
