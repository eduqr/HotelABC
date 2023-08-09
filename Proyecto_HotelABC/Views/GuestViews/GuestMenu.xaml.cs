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

namespace Proyecto_HotelABC.Views.GuestViews
{
    /// <summary>
    /// Lógica de interacción para GuestMenu.xaml
    /// </summary>
    public partial class GuestMenu : Window
    {
        public GuestMenu()
        {
            InitializeComponent();
        }

        private void Btn_Reserva(object sender, RoutedEventArgs e)
        {
            BookingView bookingView = new BookingView();
            this.Close();
            bookingView.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReviewCreate reviewmenu = new ReviewCreate();
            this.Close();
            reviewmenu.Show();
        }

        private void BTN_SignOff_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            Close();
            login.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            roomService servicios = new roomService();
            this.Close();
            servicios.Show();
        }
    }
}
