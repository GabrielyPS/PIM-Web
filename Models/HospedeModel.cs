using System.ComponentModel.DataAnnotations;

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