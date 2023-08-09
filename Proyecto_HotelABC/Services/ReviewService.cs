using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HotelABC.Services
{
    public class ReviewService
    {
        public void CreateReview(Count newCount, string userEmail1)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {

                    var existingUser = _context.Counts.FirstOrDefault(c => c.Mail == userEmail1);
                    if (existingUser == null)
                    {
                        throw new Exception("No se encontró la cuenta de correo en la base de datos.");
                    }


                    newCount.PkCount = existingUser.PkCount;


                    _context.Counts.Add(newCount);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error (CreateBookingWithAccount): " + ex.Message);
            }
        }
        public static void SaveReview(string reviewText, string userEmail)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // Buscar el usuario existente en la base de datos
                    var existingUser = context.Counts.FirstOrDefault(c => c.Mail == userEmail);
                    if (existingUser == null)
                    {
                        throw new Exception("No se encontró la cuenta de correo en la base de datos.");
                    }

                    // Crear una nueva instancia de la entidad reviews con los datos de la reseña
                    review newReview = new review
                    {
                        Namereview = reviewText,
                        Mail = userEmail
                    };

                    // Agregar la nueva reseña al DbSet de reviews
                    context.reviews.Add(newReview);

                    // Guardar los cambios en la base de datos
                    context.SaveChanges();
                }

                Console.WriteLine("Reseña guardada correctamente en la base de datos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la reseña: " + ex.Message);
            }
        }
    }
}
