using System;

namespace Service.Entities
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
