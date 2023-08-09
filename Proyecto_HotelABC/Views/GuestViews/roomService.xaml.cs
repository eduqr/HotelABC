using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Entities;
using Proyecto_HotelABC.Services;
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
    /// Lógica de interacción para roomService.xaml
    /// </summary>
    public partial class roomService : Window
    {
        
        public roomService()
        {
            InitializeComponent();
            Loaded += roomService_Loaded;
        }

        private void roomService_Loaded(object sender, RoutedEventArgs e)
        {
            var roomServices = LoadRoomServicesFromDatabase();


            cmbselectservice.ItemsSource = roomServices;
        }

        private List<RoomServices> LoadRoomServicesFromDatabase()
        {
            using (var dbContext = new ApplicationDbContext()) 
            {
                // Obtenemos los servicios desde la base de datos
                var roomServices = dbContext.RoomServices.ToList();
                return roomServices;
            }
        }

        private void BTN_Request_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obtener el servicio seleccionado por el huésped desde el ComboBox
                var selectedService = cmbselectservice.SelectedItem as RoomServices;

                // Obtener el correo electrónico del huésped desde el TextBox
                var guestEmail = txtGuestEmail.Text;

                // Validar que se haya seleccionado un servicio y se haya ingresado un correo electrónico
                if (selectedService == null || string.IsNullOrEmpty(guestEmail))
                {
                    MessageBox.Show("Por favor, seleccione un servicio y proporcione su correo electrónico antes de solicitar el servicio.");
                    return;
                }

                // Llamar al método para solicitar el servicio al cuarto
                var roomServicess = new RoomServicess(); // Crea una instancia de la clase RoomServicess
                roomServicess.AddService(selectedService, guestEmail);

                MessageBox.Show("El servicio ha sido solicitado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al solicitar el servicio: " + ex.Message);
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
