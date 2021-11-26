using ClassLibrary1.Entities;
using ClassLibrary1.Repositories;
using Service.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PIM_Web.Views.Reserva
{
    public class ReservaRepository
    {
        private static SqlConnection _connection;
        private static SqlCommand _commando;
        public void InsertReserva(Reservas entity, Hospede entityHosp)
        {
            try
            {
                var hospedeRepository = new HospedeRepository();
                var hospede = hospedeRepository.GetHospByCpf(entityHosp.Cpf);
                if (hospede is null)
                {
                    hospede = new Hospede();
                    hospede.NewHospede(entityHosp.Nome, entityHosp.Cpf);
                    hospedeRepository.Insert(entityHosp);
                }
                _connection = Connection.GetConnection();
                var id = new Random();

                _commando = new SqlCommand
                {
                    Connection = _connection,
                    CommandText = $"INSERT INTO tblreserva(hospid, reservadias, reservadt, reservaid) VALUES ({hospede.Id}, {entity.ReservaDias}, {entity.ReservaDt}, {id.Next()})"
                };
                _commando.ExecuteNonQuery();
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
    }
}