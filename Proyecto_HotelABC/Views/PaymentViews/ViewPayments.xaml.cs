using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Views.ManagerViews;
using System;
using Proyecto_HotelABC.Entities;
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
using Proyecto_HotelABC.Services;

namespace Proyecto_HotelABC.Views.PaymentViews
{
    /// <summary>
    /// Lógica de interacción para ViewPayments.xaml
    /// </summary>
    public partial class ViewPayments : Window
    {
        PaymentServices paymentServices = new PaymentServices();
        public ViewPayments()
        {
            InitializeComponent();
            GetPaymentsTable();
        }

        public void GetPaymentsTable()
        {
            Paymentstable.ItemsSource = paymentServices.GetPagos();
        }

        private void BTN_GoBack_Click(object sender, RoutedEventArgs e)
        {
            ManagerMenu manager = new ManagerMenu();
            this.Close();
            manager.Show();


        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            CleanTXTs();
        }

        private void CleanTXTs()
        {
            TXT_ID.Clear();
            TXT_Titular.Clear();
            TXT_Descripcion.Clear();
            TXT_Fecha.Clear();
        }

        private void Button_Search(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    int paymentId = int.Parse(TXT_ID.Text);
                    Payment paid = _context.Payments.Find(paymentId);
                    if (paid == null)
                    {
                        MessageBox.Show("Pago no encontrado");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Pago encontrado");
                        TXT_Titular.Text = paid.Card_Holder;
                        TXT_Descripcion.Text = paid.Description;
                        TXT_Total.Text = paid.Total.ToString();
                        TXT_Fecha.Text = paid.Date.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (ViewPayment_Button_Search)" + ex.Message);
            }
        }
    }
}
