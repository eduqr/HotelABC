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
    /// Lógica de interacción para Payment_View.xaml
    /// </summary>
    public partial class Payment_View : Window
    {
        public Payment_View()
        {
            InitializeComponent();
        }

        private void Button_Pagar(object sender, RoutedEventArgs e)
        {
            GuestMenu guestMenu = new GuestMenu();
            MessageBox.Show("Pago realizado exitosamente. Gracias por reservar con nosotros.", "Pago Exitoso", MessageBoxButton.OK, MessageBoxImage.Information);

            
            this.Close();
            guestMenu.Show();


        }
    }
}
