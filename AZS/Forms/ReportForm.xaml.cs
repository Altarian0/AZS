using AZS.Pages;
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
using System.Windows.Shapes;

namespace AZS.Forms
{
    /// <summary>
    /// Логика взаимодействия для ReportForm.xaml
    /// </summary>
    public partial class ReportForm : Window
    {
        public ReportForm()
        {
            InitializeComponent();


        }

        private void MagazineComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MagazineComboBox.SelectedIndex == 0)
            {
                InfoFrame.Navigate(new SaleInfoPage());
            }
            else if (MagazineComboBox.SelectedIndex == 1)
            {
                InfoFrame.Navigate(new DeliveryInfoPage());

            }
            else if (MagazineComboBox.SelectedIndex == 2)
            {
                InfoFrame.Navigate(new ShiftInfoPage());

            }
        }
    }
}
