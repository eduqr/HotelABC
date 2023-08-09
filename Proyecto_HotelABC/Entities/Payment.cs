using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HotelABC.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public string Card_Holder { get; set; }
        public string Description { get; set; }
    }
}
