using MyC_49.Irepasiroti;
using MyC_49.Transishn;
using MyC_49.Transishn.RequestModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Repository
{
    public class RepasitoriCarCrash : IRepasitori<CrashedCar, RequestCrashCars>
    {
        public const string CS = "Data Source=.;Initial Catalog = CarsDb; Integrated Security = True; Encrypt=False";
        public void Addd(CrashedCar t)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into CarHadCrash values(@Id,@CarCrash,@Caficent)";
                    command.Parameters.Add(new SqlParameter("@Id", t.Id));
                    command.Parameters.Add(new SqlParameter("@CarCrash", t.CarCrash));
                    command.Parameters.Add(new SqlParameter("@Caficent", t.Caficent));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Deletee(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM CarHadCrash WHERE Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", Id));

                    command.ExecuteNonQuery();
                }
            }
        }

        public CrashedCar GetById(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                CrashedCar crashedCar = new CrashedCar();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from CarHadCrash where Id = @Id";
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

        public List<CrashedCar> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                List<CrashedCar> crashedCars = new List<CrashedCar>();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from CarHadCrash";

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

        public void Updatee(CrashedCar t)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update CarHadCrash set CarCrash = @CarCrash where Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", t.Id));
                    command.Parameters.Add(new SqlParameter("@CarCrash", t.CarCrash));
                    command.Parameters.Add(new SqlParameter("@Caficent", t.Caficent));

                    command.ExecuteNonQuery();
                }
            }
        }

        public CrashedCar Find(RequestCrashCars request)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                CrashedCar crashedCar = new CrashedCar();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from CarHadCrash where CarCrash = @CarCrash";
                    command.Parameters.Add(new SqlParameter("@CarCrash", request.CarCrash));

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
    }
}
