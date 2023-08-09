using Microsoft.EntityFrameworkCore;
using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Entities;
using Proyecto_HotelABC.Views.GuestViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HotelABC.Services
{
    public class RoomServicess
    {

        public void AddService(RoomServices newService, string userEmail)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    // Buscamos al usuario asociado al correo electrónico y que tenga el rol de huésped (FkRole == 3)
                    var existingUser = _context.Counts.FirstOrDefault(c => c.Mail == userEmail && c.FkRole == 3);

                    if (existingUser == null)
                    {
                        throw new Exception("No se encontró una cuenta de huésped asociada a este correo electrónico.");
                    }

                    // Asociamos el nuevo servicio al cuarto con el huésped
                    existingUser.RequestedServices.Add(newService);

                    // Guardamos los cambios en la base de datos
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error (AddService): " + ex.Message);
            }
        }
    }
}
