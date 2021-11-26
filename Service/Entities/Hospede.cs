using System;

namespace Service.Entities
{
    public class Hospede
    {
        public int Id { get; protected set; }
        public string Nome { get; set; }
        public decimal Cpf { get; set; }

        public void NewHospede(string nome, decimal cpf)
        {
            var randomId = new Random();
            Id = randomId.Next();
            Cpf = cpf;
            Nome = nome;
        }
        public void SetHospede(int id)
        {
            Id = id;
        }
    }
}
