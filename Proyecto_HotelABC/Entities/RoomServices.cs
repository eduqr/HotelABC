using Proyecto_HotelABC.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HotelABC.Entities
{
    public class RoomServices
    {
        [Key]
        public int Pkservice { get; set; }
        public string NameService { get; set; }

        public virtual ICollection<Count> GuestAccounts { get; set; } = new HashSet<Count>();

        // Método para precargar servicios al cuarto en la base de datos
        public static void PreloadRoomServices()
        {
            using (var dbContext = new ApplicationDbContext())
            {

                if (dbContext.RoomServices.Any())
                {
                    // Si ya existen registros, no hacemos nada
                    return;
                }

                // Si no existen registros, procedemos a precargar los servicios
                var servicesToPreload = new List<RoomServices>
            {
                new RoomServices { NameService = "Limpieza" },
                new RoomServices { NameService = "Menu" },
                new RoomServices { NameService = "Lavanderia" },
                new RoomServices { NameService = "Despertador" },
                new RoomServices { NameService = "Spa" }
            };

                // Agregamos los servicios al contexto y guardamos los cambios en la base de datos
                dbContext.RoomServices.AddRange(servicesToPreload);
                dbContext.SaveChanges();
            }
        }

    }

}
