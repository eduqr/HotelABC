using Org.BouncyCastle.Asn1.X509;
using Proyecto_HotelABC.Entities;
using System;
using Stripe;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Services;

namespace Proyecto_HotelABC.Views
{
    /// <summary>
    /// Lógica de interacción para PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        PaymentServices paymentServices = new PaymentServices();
        int total;
        

        public PaymentWindow()
        {
            InitializeComponent();
            AsignarTotal(total);
            
            Label_Price.Visibility = Visibility.Visible;
        }

        public void AsignarTotal(int precio)
        {
            total = precio;
            Label_Price.Content = "$" + total + ".00";
        }

        private void Btn_Pay(object sender, RoutedEventArgs e)
        {

            try
            {

                StripeConfiguration.SetApiKey("sk_test_51L1nJ6KJ39qpYxSVdNU2LImvvprzU0KjW68MEaRzaZHMFJM8jTrm7hqPQCaI1EgQssdXzdHaDpmEIvKNcJAIpkbt00Uqy4aQ6A"); //Prueba
                                                                                                                                                              //StripeConfiguration.SetApiKey("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"); //Financiero

                var options = new PaymentMethodCreateOptions
                {
                    Type = "card",
                    Card = new PaymentMethodCardOptions
                    {
                        Number = TxtBx_CardNumber.Text,
                        ExpMonth = Convert.ToInt32(TxtBx_ExDateMonth.Text),
                        ExpYear = Convert.ToInt32(TxtBx_ExDateYear.Text),
                        Cvc = TxtBx_CVC.Text
                    }
                };

                var service = new PaymentMethodService();
                var paymentMethod = service.Create(options);

                var paymentIntentService = new PaymentIntentService();
                var createOptions = new PaymentIntentCreateOptions
                {
                    Amount = total,
                    Currency = "MXN",
                    PaymentMethod = paymentMethod.Id,
                    ConfirmationMethod = "manual",
                    Confirm = true
                };

                var paymentIntent = paymentIntentService.Create(createOptions);

                MessageBox.Show("Pago realizado con éxito. \nEstado: " + paymentIntent.Status + "\n¡Reserva agregada!");

                using (var _context = new ApplicationDbContext())
                {
                    var pay = new Payment
                    {
                        Card_Holder = TxtBx_Owner.Text,
                        Date = DateTime.Now,
                        Total = total,
                        Description = "Reserva"
                    };

                    paymentServices.AddPay(pay);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error {VisualPayment_Pay}" + ex.Message);
            }

        }

       

        //private void Pay(object sender, RoutedEventArgs e, int precio, string servicio)
        //{
        //try
        //{

        //    StripeConfiguration.SetApiKey("sk_test_51L1nJ6KJ39qpYxSVdNU2LImvvprzU0KjW68MEaRzaZHMFJM8jTrm7hqPQCaI1EgQssdXzdHaDpmEIvKNcJAIpkbt00Uqy4aQ6A"); //Prueba
        //    //StripeConfiguration.SetApiKey("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"); //Financiero

        //    var options = new PaymentMethodCreateOptions
        //    {
        //        Type = "Tarjeta Debito",
        //        Card = new PaymentMethodCardOptions
        //        {
        //            Number = TxtBx_CardNumber.Text,
        //            ExpMonth = Convert.ToInt32(TxtBx_ExDateMonth.Text),
        //            ExpYear = Convert.ToInt32(TxtBx_ExDateYear.Text),
        //            Cvc = TxtBx_CVC.Text
        //        }
        //    };

        //    var service = new PaymentMethodService();
        //    var paymentMethod = service.Create(options);

        //    var paymentIntentService = new PaymentIntentService();
        //    var createOptions = new PaymentIntentCreateOptions
        //    {
        //        Amount = precio,
        //        Currency = "MXN",
        //        PaymentMethod = paymentMethod.Id,
        //        ConfirmationMethod = "manual",
        //        Confirm = true
        //    };

        //    var paymentIntent = paymentIntentService.Create(createOptions);

        //    MessageBox.Show("Pago realizado con éxito. \nEstado: " + paymentIntent.Status + "\n¡Reserva agregada!");

        //    using (var _context = new ApplicationDbContext())
        //    {
        //        var pay = new Payment{
        //            Card_Holder = TxtBx_Owner.Text,
        //            Date = DateTime.Now,
        //            Total = precio,
        //            Description = servicio
        //        };

        //        paymentServices.AddPay(pay);
        //    }


        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Ha ocurrido un error {VisualPayment_Pay}" + ex.Message);
        //}
        //}




    }
}
