using ClassLibrary1.Entities;
using Service.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositories
{
    public class HospedeRepository
    {
        private static SqlConnection _connection;

        public Hospede GetHospByCpf(decimal cpf)
        {
            try
            {
                var connection = Connection.GetConnection();
                var sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection;
                var sqlQuery = new StringBuilder();
                sqlCommand.CommandText = $"SELECT hospid FROM tblhospede WHERE hospcpf = {cpf}";
                var readerQuery = sqlCommand.ExecuteReader();
                if (!readerQuery.HasRows)
                    return null;
                else
                {
                    var hospede = new Hospede();
                    while (readerQuery.Read())
                    {
                        hospede.SetHospede(readerQuery.GetInt32(0));
                        break;

                    }
                    return hospede;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Hospede Insert(Hospede model)
        {
            try
            {
                _connection = Connection.GetConnection();
                var _commando = new SqlCommand
                {
                    Connection = _connection,
                    CommandText = $"insert into tblhospede (hospid, hospnome, hospcpf) values ({model.Id}, {model.Nome}, {model.Cpf})"
                };

                Connection.CloseConnection();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
