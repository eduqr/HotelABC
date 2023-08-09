using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HotelABC.Entities
{
    internal class review
    {
        [Key]
        public int IdReview { get; set; }
        public string Namereview { get; set; }
        public string Mail { get; set; }
        public DateTime  dateTime { get; set;}
        public string Text { get; set;}
        
    }
}
