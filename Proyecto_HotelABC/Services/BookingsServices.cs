using Microsoft.EntityFrameworkCore;
using Proyecto_HotelABC.Context;
using Proyecto_HotelABC.Entities;
using Proyecto_HotelABC.Validations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_HotelABC.Services
{
    public class BookingsServices
    {

        public void CreateOrUpdateBookingWithAccount(Booking booking, string userEmail)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    var existingUser = _context.Counts.FirstOrDefault(c => c.Mail == userEmail);
                    if (existingUser == null)
                    {
                        throw new Exception("No se encontró la cuenta de correo en la base de datos.");
                    }

                    var existingBooking = _context.Bookings.FirstOrDefault(b => b.CountId == existingUser.PkCount);
                    //var pricing = _context.SuiteNames.Find(existingBooking.Suite);
                    if (existingBooking != null)
                    {

                        existingBooking.Days = booking.Days;
                        existingBooking.AmountPerson = booking.AmountPerson;
                        existingBooking.Suite = booking.Suite;
                       // existingBooking.Price = pricing.Price * booking.Days;
                    }
                    else
                    {

                        booking.CountId = existingUser.PkCount;
                        _context.Bookings.Add(booking);
                    }

                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error (CreateOrUpdateBookingWithAccount): " + ex.Message);
            }
        }
    

       

        public void DeleteBooking(Booking booking)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    _context.Bookings.Remove(booking);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error (DeleteBooking): " + ex.Message);
            }
        }


        public List<Booking> GetBookings()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    List<Booking> bookings = _context.Bookings.Include(b => b.User).ToList();
                    return bookings;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error (GetBookings)" + ex.Message);
            }
        }

        public void GenerateSuites()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    bool BasicSuite = _context.SuiteNames.Any(role => role.NameS == "Basic");
                    bool PlusSuite = _context.SuiteNames.Any(role => role.NameS == "Plus");
                    bool PremiumSuite = _context.SuiteNames.Any(role => role.NameS == "Premium");
                    bool DeluxeSuite = _context.SuiteNames.Any(role => role.NameS == "DeluxeSuite");



                    if (!BasicSuite)
                    {
                        var Basic = new SuiteNames
                        {
                            NameS = "Basic",
                            Price = 1000
                        };

                        _context.SuiteNames.Add(Basic);
                        _context.SaveChanges();
                    }

                    if (!PlusSuite)
                    {
                        var Plus = new SuiteNames
                        {
                            NameS = "Plus",
                            Price=1500
                        };

                        _context.SuiteNames.Add(Plus);
                        _context.SaveChanges();
                    }

                    if (!PremiumSuite)
                    {
                        var Premium = new SuiteNames
                        {
                            NameS = "Premium",
                            Price=2000
                        };

                        _context.SuiteNames.Add(Premium);
                        _context.SaveChanges();
                    }
                    if (!DeluxeSuite)
                    {
                        var Deluxe = new SuiteNames
                        {
                            NameS = "DeluxeSuite",
                            Price=2000
                        };

                        _context.SuiteNames.Add(Deluxe);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error (GenerateSuites) " + ex.Message);
            }

        }

        public List<SuiteNames> GetSuites()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    List<SuiteNames> suites = _context.SuiteNames.ToList();
                    return suites;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error (GetSuites)" + ex.Message);
            }
        }

    }
}
