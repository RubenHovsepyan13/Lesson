using MyC_49.Irepasiroti;
using MyC_49.Transishn;
using MyC_49.Transishn.RequestModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Repository
{
    public class RepasitoriCarType : IRepasitori<CarType, RequestCarType>
    {
        public const string CS = "Data Source=.;Initial Catalog = CarsDb; Integrated Security = True; Encrypt=False";
        public void Addd(CarType carType)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into CarType values(@Id,@Type,@Caficent)";
                    command.Parameters.Add(new SqlParameter("@Id", carType.Id));
                    command.Parameters.Add(new SqlParameter("@Type", carType.Type));
                    command.Parameters.Add(new SqlParameter("@Caficent", carType.Caficent));

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
                    command.CommandText = "DELETE FROM CarType WHERE Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", Id));

                    command.ExecuteNonQuery();
                }
            }
        }

        public CarType GetById(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                CarType carType = new CarType();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from CarType where Id = @Id";
                    command.Parameters.Add(new SqlParameter("@id", Id));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            carType.Id = int.Parse(reader["Id"].ToString());
                            carType.Type = reader["Type"].ToString();
                            carType.Caficent = int.Parse(reader["Caficent"].ToString());
                        }
                    }
                }
                return carType;
            }
        }

        public List<CarType> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                List<CarType> carTypes = new List<CarType>();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from CarType";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CarType carType = new CarType();

                            carType.Id = int.Parse(reader["Id"].ToString());
                            carType.Type = reader["Type"].ToString();
                            carType.Caficent = int.Parse(reader["Caficent"].ToString());

                            carTypes.Add(carType);
                        }
                    }
                }
                return carTypes;
            }
        }

        public void Updatee(CarType carType)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update CarType set Type = @Type, Caficent = @Caficent where Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", carType.Id));
                    command.Parameters.Add(new SqlParameter("@Type", carType.Type));
                    command.Parameters.Add(new SqlParameter("@Caficent", carType.Caficent));

                    command.ExecuteNonQuery();
                }
            }
        }

        public CarType Find(RequestCarType request)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                CarType carType = new CarType();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from CarType where Type = @Type";
                    command.Parameters.Add(new SqlParameter("@Type", request.Type));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            carType.Id = int.Parse(reader["Id"].ToString());
                            carType.Type = reader["Type"].ToString();
                            carType.Caficent = int.Parse(reader["Caficent"].ToString());
                        }
                    }
                }
                return carType;
            }
        }
    }
}
