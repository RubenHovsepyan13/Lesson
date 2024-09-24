using MyC_49.Irepasiroti;
using MyC_49.Transishn;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.repasitori
{
    internal class RepasitoriConteiner : IRepasitori<Cantainer>
    {
        public const string CS = "Data Source=.;Initial Catalog = CarsDb; Integrated Security = True; Encrypt=False";
        public void Add(Cantainer t)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Avelacnel (@Id,@Open,@Caficent)";
                    command.Parameters.Add(new SqlParameter("@Id", t.Id));
                    command.Parameters.Add(new SqlParameter("@Open", t.Open));
                    command.Parameters.Add(new SqlParameter("@Caficent", t.Caficent));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Dilete by = @ID";
                    command.Parameters.Remove(new SqlParameter("@ID", Id));

                    command.ExecuteNonQuery();
                }
            }
        }

        public Cantainer Find(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                Cantainer cantainer = new Cantainer();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Find by @Id";
                    command.Parameters.Add(new SqlParameter("Id", Id));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cantainer.Id = int.Parse(reader["Id"].ToString());
                            cantainer.Open = bool.Parse(reader["Open"].ToString());
                            cantainer.Caficent = int.Parse(reader["Caficent"].ToString());

                        }
                    }
                }
                return cantainer;
            }
        }

        public List<Cantainer> FindAll()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                List<Cantainer> cantainers = new List<Cantainer>();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert All";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cantainer cantainer = new Cantainer();

                            cantainer.Id = int.Parse(reader["Id"].ToString());
                            cantainer.Open = bool.Parse(reader["Open"].ToString());
                            cantainer.Caficent = int.Parse(reader["Cficent"].ToString());

                            cantainers.Add(cantainer);
                        }
                    }
                }
                return cantainers;
            }
        }

        public void Update(Cantainer t)
        {
            using(SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Updat by @Id";
                    command.Parameters.Add(new SqlParameter("@Open", t.Open));
                    command.Parameters.Add(new SqlParameter("@Caficent",t.Caficent));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
