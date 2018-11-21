using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottonCompany.Model
{
    class DeliveryRepository : IRepository<NFilter>
    {

      

        public Dictionary<int, string> GetByName(string linkedtable, string LinkedfieldGetvalue, string LinkedfieldToshow)
        {
            Dictionary<int, string> Items = new Dictionary<int, string>();

            var connString = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT (@id), (@field) FROM (@table)";
                    cmd.Parameters.AddWithValue("id", LinkedfieldGetvalue);
                    cmd.Parameters.AddWithValue("field", LinkedfieldToshow);
                    cmd.Parameters.AddWithValue("table", linkedtable);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            Items.Add((int)reader[0], (string)reader[1]);
                }

            }

            return Items;

        }

        public void Create(NFilter item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(NFilter item)
        {
            throw new NotImplementedException();
        }
    }
}
