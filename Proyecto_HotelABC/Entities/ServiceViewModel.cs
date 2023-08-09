using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HotelABC.Entities
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public int PkService{ get; set; } // Agregar esta propiedad para contener el Id del servicio en la base de datos
        public string Correo { get; set; }
        public string NameService { get; set; }
        public bool IsRequestedService { get; set; }
    }
}
