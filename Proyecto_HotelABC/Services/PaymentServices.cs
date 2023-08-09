using Proyecto_HotelABC.Context;
using System;
using Proyecto_HotelABC.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Proyecto_HotelABC.Services
{
    public class PaymentServices
    {
        public void AddPay(Payment request)
        {
            try
            {
                if (request != null)
                {
                    using (var _context = new ApplicationDbContext())
                    {
                        Payment res = new Payment();

                        res.Id = request.Id;
                        res.Total = request.Total;
                        res.Date = request.Date;
                        res.Card_Holder = request.Card_Holder;
                        res.Description = request.Description;
                        _context.Payments.Add(res);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedio un error " + ex.Message, ex);
            }
        }

        public void UpdatePay(Payment request)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Payment pagos = _context.Payments.Find(request.Id);
                    pagos.Total = request.Total;
                    pagos.Date = request.Date;

                    _context.Update(pagos);

                    _context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error " + ex.Message);
            }
        }

        public List<Payment> GetPagos()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {

                    List<Payment> payments = _context.Payments.ToList();

                    return payments;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error " + ex.Message);
            }
        }

        public void DeletePay(int id)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Payment payment = _context.Payments.Find(id);
                    if (payment != null)
                    {
                        _context.Payments.Remove(payment);
                        _context.SaveChanges();
                        MessageBox.Show("El pago fue eliminado.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún pago con el ID especificado.");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Succedio un error" + ex.Message);
            }
        }
    }
}
