using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Entities;
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
    /// Lógica de interacción para ManageRoomServices.xaml
    /// </summary>
    public partial class ManageRoomServices : Window
    {
        public ManageRoomServices()
        {
            InitializeComponent();
            Loaded += ManageServices_Loaded;
        }
        private void ManageServices_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            try
            {
                var serviceViewModelList = new List<ServiceViewModel>();

                using (var _context = new ApplicationDbContext())
                {
                    var services = _context.RoomServices.ToList();

                    foreach (var service in services)
                    {
                        // Obtener todos los correos de los huéspedes asociados al servicio
                        var guestEmails = _context.Counts
                            .Where(c => c.RequestedServices.Any(rs => rs.Pkservice == service.Pkservice))
                            .Select(c => c.Mail)
                            .ToList();


                        foreach (var guestEmail in guestEmails)
                        {
                            serviceViewModelList.Add(new ServiceViewModel
                            {

                                Correo = guestEmail,
                                NameService = service.NameService
                            });
                        }
                    }
                }


                dgServices.ItemsSource = serviceViewModelList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void BTN_Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var button = sender as Button;
                if (button != null)
                {
                    var serviceViewModel = button.DataContext as ServiceViewModel;
                    if (serviceViewModel != null)
                    {
                        var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este servicio?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);

                        if (result == MessageBoxResult.Yes)
                        {

                            var serviceId = serviceViewModel.Id;


                            var serviceViewModelList = (List<ServiceViewModel>)dgServices.ItemsSource;
                            var serviceToDelete = serviceViewModelList.FirstOrDefault(s => s.Id == serviceId);
                            if (serviceToDelete != null)
                            {
                                serviceViewModelList.Remove(serviceToDelete);
                            }


                            dgServices.Items.Refresh();


                            using (var _context = new ApplicationDbContext())
                            {
                                var serviceInDatabase = _context.RoomServices.FirstOrDefault(s => s.Pkservice == serviceId);
                                if (serviceInDatabase != null)
                                {
                                    _context.RoomServices.Remove(serviceInDatabase);
                                    _context.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el servicio: " + ex.Message);
            }
        }

        private void BTN_GoBack_Click(object sender, RoutedEventArgs e)
        {
            ManagerMenu menu = new ManagerMenu();
            this.Close();
            menu.Show();
        }
    }
}
