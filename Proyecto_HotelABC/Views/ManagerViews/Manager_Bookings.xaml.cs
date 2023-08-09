using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Entities;
using Proyecto_HotelABC.Services;
using Proyecto_HotelABC.Validations;
using Proyecto_HotelABC.Views.EmployeeViews;
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
    /// Lógica de interacción para Manager_Bookings.xaml
    /// </summary>
    public partial class Manager_Bookings : Window
    {
        BookingsServices bookingsServices = new BookingsServices();
        PaymentWindow pay = new PaymentWindow();
        public Manager_Bookings()
        {
            InitializeComponent();
            GetSuites();
            GetBookingsTable();
        }

        public void GetSuites()
        {
            SelectSuites.ItemsSource = bookingsServices.GetSuites();
            SelectSuites.DisplayMemberPath = "NameS";
            SelectSuites.SelectedValuePath = "PkName";
        }
        public void GetBookingsTable()
        {
            Bookingstable.ItemsSource = bookingsServices.GetBookings();
        }

        private void BTN_GoBack_Click(object sender, RoutedEventArgs e)
        {
           ManagerMenu manager = new ManagerMenu();
            this.Close();
            manager.Show();
            
            
        }

        private void Button_Reserve(object sender, RoutedEventArgs e)
        {
            
            try
            {
                var textBoxesToValidate = new List<TextBox>
                {
                    TXT_Amount,
                    TXT_Days,
                    TXT_Lastname,
                    TXT_Mail,
                    TXT_Name,
                };


                if (InputValidator.AreTextBoxesEmpty(textBoxesToValidate))
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }

                if (SelectSuites.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una Suite valida");
                    return;
                }
                if (!InputValidator.IsValidEmail(TXT_Mail.Text))
                {
                    MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida.");
                    return;
                }

                if (!InputValidator.IsNumber(TXT_Days.Text))
                {
                    MessageBox.Show("Por favoor, verifique la cantidad de días");
                    return;
                }


                int days = int.Parse(TXT_Days.Text);
                int amountPerson = int.Parse(TXT_Amount.Text);
                int selectedSuiteId = int.Parse(SelectSuites.SelectedValue.ToString());
                string userEmail = TXT_Mail.Text;

                Booking newBooking = new Booking
                {
                    Days = days,
                    AmountPerson = amountPerson,
                    Suite = selectedSuiteId
                };
                bookingsServices.CreateOrUpdateBookingWithAccount(newBooking, userEmail);

                MessageBox.Show("Reservación creada o actualizada exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                GetBookingsTable();

                using (var _context = new ApplicationDbContext())
                {
                    SuiteNames suitereserved = _context.SuiteNames.Find(newBooking.Suite);
                    newBooking.Price = suitereserved.Price * newBooking.Days;
                    pay.AsignarTotal(newBooking.Price);
                    pay.ShowDialog();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar o actualizar la reservación: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private Booking selectedBooking;
        public void BTN_EditItem_Click(object sender, RoutedEventArgs e)
        {
            if (Bookingstable.SelectedItem is Booking selectedBooking)
            {

                this.selectedBooking = selectedBooking;


                TXT_Mail.Text = selectedBooking.Mail;
                TXT_Name.Text = selectedBooking.Name;
                TXT_Lastname.Text = selectedBooking.LastName;
                TXT_Days.Text = selectedBooking.Days.ToString();
                TXT_Amount.Text = selectedBooking.AmountPerson.ToString();
                SelectSuites.SelectedValue = selectedBooking.Suite;
            }

        }
        private void BTN_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (Bookingstable.SelectedItem is Booking selectedBooking)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta reservación?", "Confirmar Eliminación", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        bookingsServices.DeleteBooking(selectedBooking);

                        MessageBox.Show("Reservación eliminada exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                        GetBookingsTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la reservación: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reservación para eliminar.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

       
        
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            CleanTXTs();
        }

        private void CleanTXTs()
        {
            TXT_Mail.Clear();
            TXT_Name.Clear();
            TXT_Lastname.Clear();
            TXT_Mail.Clear();
            TXT_Days.Clear();
            TXT_Amount.Clear();
        }

       
    }
}
