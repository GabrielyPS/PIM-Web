using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIM_Web.Models
{
    public class ReservaModel
    {
        [Key]
        public int Id { get; set; }
        public int HospId { get; set; }
        public int ReservaDias { get; set; }
        public DateTime ReservaDt { get; set; }

    }
}