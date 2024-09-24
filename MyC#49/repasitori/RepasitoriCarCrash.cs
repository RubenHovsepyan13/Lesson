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
    internal class RepasitoriCarCrash : IRepasitori<CrashedCar>
    {
        public const string CS = "Data Source=.;Initial Catalog = CarsDb; Integrated Security = True; Encrypt=False";
        public void Add(CrashedCar t)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Avelacnel (@Id,@CarCrash,@Caficent)";
                    command.Parameters.Add(new SqlParameter("@Id", t.Id));
                    command.Parameters.Add(new SqlParameter("@CarCarsh", t.CarCrash));
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
                    command.CommandText = "Delete by @id";
                    command.Parameters.Remove(new SqlParameter("Id", Id));

                    command.ExecuteNonQuery();
                }
            }
        }

        public CrashedCar Find(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                CrashedCar crashedCar = new CrashedCar();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Find by @Id";
                    command.Parameters.Add(new SqlParameter("@CarCrash", Id));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            crashedCar.Id = int.Parse(reader["Id"].ToString());
                            crashedCar.CarCrash = bool.Parse(reader["CarCrash"].ToString());
                            crashedCar.Caficent = int.Parse(reader["Caficent"].ToString());
                        }
                    }
                }
                return crashedCar;
            }
        }

        public List<CrashedCar> FindAll()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                List<CrashedCar> crashedCars = new List<CrashedCar>();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Bolory";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CrashedCar crashedCar = new CrashedCar();

                            crashedCar.Id = int.Parse(reader["Id"].ToString());
                            crashedCar.CarCrash = bool.Parse(reader["CarCrash"].ToString());
                            crashedCar.Caficent = int.Parse(reader["Caficent"].ToString());

                            crashedCars.Add(crashedCar);
                        }
                    }
                }
                return crashedCars;
            }
        }

        public void Update(CrashedCar t)
        {
            using(SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "All informacia by = @Id";
                    command.Parameters.Add(new SqlParameter("@CarCrash", t.CarCrash));
                    command.Parameters.Add(new SqlParameter("@Caficent",t.Caficent));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
