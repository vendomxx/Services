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

namespace IlvinaServis.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicesViewPage.xaml
    /// </summary>
    public partial class ServicesViewPage : Page
    {
        IEnumerable<Service> services = MainWindow.DB.Service.ToList();
        public ServicesViewPage()
        {
            InitializeComponent();

            servicesLV.ItemsSource = services;
        }

        private void discountCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (discountCB.SelectedIndex == 0)
                servicesLV.ItemsSource = services;
            else if (discountCB.SelectedIndex == 1)
                servicesLV.ItemsSource = services.Where(s => s.Discount > 0 && s.Discount <= 5);
            else if (discountCB.SelectedIndex == 2)
                servicesLV.ItemsSource = services.Where(s => s.Discount > 5 && s.Discount <= 15);
            else if (discountCB.SelectedIndex == 3)
                servicesLV.ItemsSource = services.Where(s => s.Discount > 15 && s.Discount <= 30);
            else if (discountCB.SelectedIndex == 4)
                servicesLV.ItemsSource = services.Where(s => s.Discount > 30 && s.Discount <= 70);
            else if (discountCB.SelectedIndex == 5)
                servicesLV.ItemsSource = services.Where(s => s.Discount > 70 && s.Discount <= 100);

        }
    }
}
