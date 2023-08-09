using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Entities;
using Proyecto_HotelABC.Services;
using Proyecto_HotelABC.Views.GuestViews;
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

namespace Proyecto_HotelABC.Views.ReviewViews
{
    /// <summary>
    /// Lógica de interacción para ReviewCreate.xaml
    /// </summary>
    public partial class ReviewCreate : Window
    {
        public ReviewCreate()
        {
            InitializeComponent();
        }
   
            private void Button_Reseña(object sender, RoutedEventArgs e)
            {
                string reseña = textboxreseña.Text;
                string correo = Mail.Text;

                if (string.IsNullOrWhiteSpace(reseña) || string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("Por favor, ingrese una reseña y un correo electrónico.");
                    return;
                }

                try
                {
               
                    using (var _context = new ApplicationDbContext())
                    {
                        review nuevaReseña = new review()
                        {
                            Namereview = reseña,
                            Mail = correo, 
                            Text = ""
                        };

                    nuevaReseña.dateTime = DateTime.Now;
                    _context.reviews.Add(nuevaReseña);
                        _context.SaveChanges();
                        
                    }

                    MessageBox.Show("Reseña almacenada correctamente en la base de datos.");
                    textboxreseña.Text = "";
                    Mail.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la reseña: " + ex.Message);
                }
            }

        private void textboxreseña_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BTN_GoBack_Click(object sender, RoutedEventArgs e)
        {
            GuestMenu menuhuesped = new GuestMenu();
            this.Close();
            menuhuesped.Show();
        }
    }
    }

