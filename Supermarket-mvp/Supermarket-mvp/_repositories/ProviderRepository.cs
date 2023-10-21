using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._repositories
{
    internal class ProviderRepository : BaseRepository, IProviderRepository
    {
        public ProviderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProviderModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Provider VALUES (@nit, @name, @address, @number)";
                command.Parameters.Add("@nit", SqlDbType.Int).Value = providerModel.Nit;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.Name;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = providerModel.Address;
                command.Parameters.Add("@number", SqlDbType.NVarChar).Value = providerModel.Number;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Provider WHERE Provider_Nit = @nit";
                command.Parameters.Add("@nit", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProviderModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Provider
                                        SET Provider_Nit = @nit,
                                        Provider_Name = @name,
                                        Provider_Address = @address,
                                        Provider_Number = @number
                                        WHERE Provider_NiT = @nit";
                command.Parameters.Add("@nit", SqlDbType.Int).Value = providerModel.Nit;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.Name;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = providerModel.Address;
                command.Parameters.Add("@number", SqlDbType.NVarChar).Value = providerModel.Number;
                
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProviderModel> GetAll()
        {
            var providerList = new List<ProviderModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Provider ORDER BY Provider_Nit DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel();
                        providerModel.Nit = (int)reader["Provider_Nit"];
                        providerModel.Name = reader["Provider_Name"].ToString();
                        providerModel.Address = reader["Provider_Address"].ToString();
                        providerModel.Number = reader["Provider_Number"].ToString();
                        providerList.Add(providerModel);

                    }
                }
            }
            return providerList;
        }

        public IEnumerable<ProviderModel> GetByValue(string value)
        {
            var providerList = new List<ProviderModel>();
            int providerNit = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providerName = value;
            string providerAddress = value;
            string providerNumber = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Provider 
                                        WHERE Provider_Nit = @nit or Provider_Name LIKE @name + '%' or Provider_Address LIKE @address + '%' or Provider_Number LIKE @number + '%'
                                        ORDER BY Provider_Nit DESC";
                command.Parameters.Add("@nit", SqlDbType.Int).Value = providerNit;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = providerAddress;
                command.Parameters.Add("@number", SqlDbType.NVarChar).Value = providerNumber;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel();
                        providerModel.Nit = (int)reader["Provider_Nit"];
                        providerModel.Name = reader["Provider_Name"].ToString();
                        providerModel.Address  = reader["Provider_Address"].ToString();
                        providerModel.Number  = reader["Provider_Number"].ToString();
                        providerList.Add(providerModel);

                    }
                }
            }
            return providerList;
        }
    }
}
