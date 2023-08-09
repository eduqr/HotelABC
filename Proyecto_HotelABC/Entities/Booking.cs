﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HotelABC.Entities
{
    public class Booking
    {
        [Key]
        public int IdReservation { get; set; }

        public int Days { get; set; }

        public int AmountPerson { get; set; }

        public int Suite { get; set; }
        public int Price { get; set; }

        [ForeignKey("Count")]
        public int? CountId { get; set; }
        public Count User { get; set; }

        [NotMapped] 
        public string Name => User?.Name;

        [NotMapped] 
        public string LastName => User?.Lastname;
        [NotMapped]
        public string Mail => User?.Mail;


    }
}
