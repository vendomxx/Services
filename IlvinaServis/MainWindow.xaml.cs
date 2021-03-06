﻿using System;
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

namespace IlvinaServis
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static IlvinaServisEntities DB = new IlvinaServisEntities();

        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new Pages.ServicesViewPage());
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoBack) mainFrame.GoBack();
            else MessageBox.Show("Вы находитесь на главной странице!","Сообщение");
        }
    }
}
