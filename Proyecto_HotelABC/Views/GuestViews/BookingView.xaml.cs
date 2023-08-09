using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Entities;
using Proyecto_HotelABC.Services;
using Proyecto_HotelABC.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_HotelABC.Views.GuestViews
{
    /// <summary>
    /// Lógica de interacción para BookingView.xaml
    /// </summary>
    public partial class BookingView : Window
    {
        BookingsServices bookingsServices = new BookingsServices();
        PaymentWindow pay = new PaymentWindow();
        public BookingView()
        {
           InitializeComponent();
           GetSuites();
        }

        

        public void GetSuites()
        {
            SelectSuites.ItemsSource = bookingsServices.GetSuites();
            SelectSuites.DisplayMemberPath = "NameS";
            SelectSuites.SelectedValuePath = "PkName";
        }

        private void Button_Reserve(object sender, RoutedEventArgs e)
        {
            Payment_View payment_View = new Payment_View(); 
            try
            {
               
                int days = int.Parse(txtDays.Text);
                int amountPerson = int.Parse(txtAmount.Text);
                int selectedSuiteId = int.Parse(SelectSuites.SelectedValue.ToString());

                var textBoxesToValidate = new List<TextBox>
                {
                  txtAmount,
                  txtDays,
                  txtMail
                };

                if (InputValidator.AreTextBoxesEmpty(textBoxesToValidate))
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }

                if (selectedSuiteId == -1)
                {
                    MessageBox.Show("Por favor, seleccione una Suite valida");
                    return;
                }



                Booking newBooking = new Booking
                {
                    Days = days,
                    AmountPerson = amountPerson,
                    Suite= selectedSuiteId
                    
                };
                string userEmail = txtMail.Text;
                MessageBox.Show("Información valida.", "Yendo al registro de pago", MessageBoxButton.OK, MessageBoxImage.Information);
                bookingsServices.CreateOrUpdateBookingWithAccount(newBooking, userEmail);
                this.Close();


                using (var _context = new ApplicationDbContext())
                {
                    SuiteNames suitereserved = _context.SuiteNames.Find(newBooking.Suite);
                    newBooking.Price = suitereserved.Price * newBooking.Days;
                    pay.AsignarTotal(newBooking.Price);
                    pay.ShowDialog();
                }
               
               payment_View.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la reservación: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BTN_GoBack_Click(object sender, RoutedEventArgs e)
        {
            GuestMenu menu = new GuestMenu();
            this.Close();
            menu.Show();
        }
    }
}
