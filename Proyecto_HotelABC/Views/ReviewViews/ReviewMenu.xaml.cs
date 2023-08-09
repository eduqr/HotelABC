using Proyecto_HotelABC.Context;
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

namespace Proyecto_HotelABC.Views.ReviewViews
{
    /// <summary>
    /// Lógica de interacción para ReviewMenu.xaml
    /// </summary>
    public partial class ReviewMenu : Window
    {
        public ReviewMenu()
        {
            InitializeComponent();
        }

        
        

        private void Mail_Text(object sender, TextChangedEventArgs e)
        {
            TxtReview.Text = "";
        }

        private void BtnViewReview_Click(object sender, RoutedEventArgs e)
        {
            string correo = Mail.Text;
            int id;

            if (string.IsNullOrWhiteSpace(correo) || !int.TryParse(ID.Text, out id))
            {
                MessageBox.Show("Por favor, ingrese un correo y un ID válidos.");
                return;
            }

            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    // Verificar si el correo electrónico existe en la base de datos
                    var existingUser = _context.Counts.FirstOrDefault(c => c.Mail == correo);
                    if (existingUser == null)
                    {
                        MessageBox.Show("No se encontró la cuenta de correo en la base de datos.");
                        return;
                    }

                    // Obtener la reseña por su ID
                    var review = _context.reviews.FirstOrDefault(r => r.IdReview == id && r.Mail == correo);
                    if (review == null)
                    {
                        MessageBox.Show("No se encontró la reseña con el ID y el correo proporcionados.");
                        return;
                    }

                    // Mostrar la reseña en el TextBox
                    TxtReview.Text = review.Namereview;
                    TxtReview.IsEnabled= false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la reseña: " + ex.Message);
            }
        }

        private void BTN_GoBack_Click(object sender, RoutedEventArgs e)
        {
            EmployeeMenu menuempleado = new EmployeeMenu();
            this.Close();
            menuempleado.Show();
        }
    }
}
