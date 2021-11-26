using System;
using System.ComponentModel.DataAnnotations;

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