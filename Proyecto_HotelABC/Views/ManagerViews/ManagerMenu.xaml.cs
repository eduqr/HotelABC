using Proyecto_HotelABC.Views.PaymentViews;
using Proyecto_HotelABC.Views.ReviewViews;
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

namespace Proyecto_HotelABC.Views.ManagerViews
{
    /// <summary>
    /// Lógica de interacción para ManagerMenu.xaml
    /// </summary>
    public partial class ManagerMenu : Window
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void BTN_ManageEmployees_Click(object sender, RoutedEventArgs e)
        {
            ManageCounts manageemployees = new ManageCounts();
            Close();
            manageemployees.Show();
        }

        private void BTN_SignOff_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            Close();
            login.Show();
        }

        private void BTN_ViewReviews_Click(object sender, RoutedEventArgs e)
        {
            ReviewMenu reviewcreate = new ReviewMenu();
            Close();
            reviewcreate.Show();
        }

        private void BTN_ManageServices_Click(object sender, RoutedEventArgs e)
        {
            ManageRoomServices managerooms = new ManageRoomServices();
            this.Close();
            managerooms.Show();
        }

        private void Btn_ManagerBookings1(object sender, RoutedEventArgs e)
        {
            Manager_Bookings manager_Bookings = new Manager_Bookings();
            this.Close();
            manager_Bookings.Show();
        }

        private void BTN_ViewPays_Click(object sender, RoutedEventArgs e)
        {
            ViewPayments payment_view = new ViewPayments();
            this.Close();
            payment_view.Show();
        }
    }
}
