using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Reservas
    {
        //hospid, reservadias, reservadt, reservaid
        public int Id { get; set; }
        public int HospId { get; set; }
        public int ReservaDias { get; set; }
        public DateTime ReservaDt { get; set; }


    }
}
