using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIM_Web.Models
{
    public class HospedeModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Cpf { get; set; }

    }
}