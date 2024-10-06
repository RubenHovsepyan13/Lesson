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
    internal class RepasitoriCarType : IRepasitori<CarType>
    {
        public const string CS = "Data Source=.;Initial Catalog = CarsDb; Integrated Security = True; Encrypt=False";
        public void Add(CarType carType)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Avelacra Tesaky(@Id,@Name,@Type,@Caficent)";
                    command.Parameters.Add(new SqlParameter("@Id", carType.Id));
                    command.Parameters.Add(new SqlParameter("@Name", carType.Name));
                    command.Parameters.Add(new SqlParameter("@Type", carType.Type));
                    command.Parameters.Add(new SqlParameter("@Caficent", carType.Caficent));

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
                    command.CommandText = "Yntrel vori Id = @Id";
                    command.Parameters.Remove(new SqlParameter("@Name", Id));

                    command.ExecuteNonQuery();
                }
            }
        }

        public CarType Find(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                CarType carType = new CarType();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select where Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Name", Id));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            carType.Id = int.Parse(reader["Id"].ToString());
                            carType.Name = reader["Name"].ToString();
                            carType.Type = reader["Type"].ToString();
                            carType.Caficent = int.Parse(reader["Caficent"].ToString());
                        }
                    }
                }
                return carType;
            }
        }

        public List<CarType> FindAll()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                List<CarType> carTypes = new List<CarType>();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Bolory";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CarType carType = new CarType();

                            carType.Id = int.Parse(reader["Id"].ToString());
                            carType.Name = reader["Name"].ToString();
                            carType.Type = reader["Type"].ToString();
                            carType.Caficent = int.Parse(reader["Caficent"].ToString());

                            carTypes.Add(carType);
                        }
                    }
                }
                return carTypes;
            }
        }

        public void Update(CarType carType)
        {
            using(SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Car(@Name,@Type,@Caficent) where = @Id";
                    command.Parameters.Add(new SqlParameter("@Name", carType.Name));
                    command.Parameters.Add(new SqlParameter("@Type",carType.Type));
                    command.Parameters.Add(new SqlParameter("@Caficent", carType.Caficent));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
