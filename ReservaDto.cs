using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIM_Web
{
    public class ReservaDto
    {
        public decimal HospCpf { get; set; }
        public string HospNome { get; set; }
        public int ReservaDias { get; set; }
        public DateTime ReservaDt { get; set; }
    }
}