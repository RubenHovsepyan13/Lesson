using MyC_49.Irepasiroti;
using MyC_49.Transishn;
using MyC_49.Transishn.RequestModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Repository
{
    public class RepasitoriDirection : IRepasitori<Direction, RequestDirection>
    {
        public const string CS = "Data Source=.;Initial Catalog = CarsDb; Integrated Security = True; Encrypt=False";
        public void Addd(Direction t)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert inio Direction values(@Id,@From,@To,@Km,@Price)";
                    command.Parameters.Add(new SqlParameter("@Id", t.Id));
                    command.Parameters.Add(new SqlParameter("@From", t.From));
                    command.Parameters.Add(new SqlParameter("@to", t.To));
                    command.Parameters.Add(new SqlParameter("@Km", t.Km));
                    command.Parameters.Add(new SqlParameter("@Price", t.Price));

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
                    command.CommandText = "Delete from Direction where Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", Id));

                    command.ExecuteNonQuery();
                }
            }
        }

        public Direction GetById(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                Direction direction = new Direction();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Cantainer where Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", Id));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            direction.Id = int.Parse(reader["Id"].ToString());
                            direction.From = reader["From"].ToString();
                            direction.To = reader["To"].ToString();
                            direction.Km = int.Parse(reader["Km"].ToString());
                            direction.Price = int.Parse(reader["Price"].ToString());
                        }
                    }
                }
                return direction;
            }
        }

        public List<Direction> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                List<Direction> directions = new List<Direction>();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Direction";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Direction direction = new Direction();

                            direction.Id = int.Parse(reader["Id"].ToString());
                            direction.From = reader["From"].ToString();
                            direction.To = reader["To"].ToString();
                            direction.Km = int.Parse(reader["Km"].ToString());
                            direction.Price = int.Parse(reader["Price"].ToString());
                        }
                    }
                }
                return directions;
            }
        }

        public void Updatee(Direction t)
        {
            using(SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Direction set From = @From,To = @To, Km = @Km, Price = @Price, where Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", t.Id));
                    command.Parameters.Add(new SqlParameter("@From", t.From));
                    command.Parameters.Add(new SqlParameter("@to", t.To));
                    command.Parameters.Add(new SqlParameter("@Km", t.Km));
                    command.Parameters.Add(new SqlParameter("@Price", t.Price));

                    command.ExecuteNonQuery();
                }
            }
        }

        public Direction Find(RequestDirection request)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                Direction direction = new Direction();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Cantainer where From = @From and To = @To";
                    command.Parameters.Add(new SqlParameter("@From", request.From));
                    command.Parameters.Add(new SqlParameter("To", request.To));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            direction.Id = int.Parse(reader["Id"].ToString());
                            direction.From = reader["From"].ToString();
                            direction.To = reader["To"].ToString();
                            direction.Km = int.Parse(reader["Km"].ToString());
                            direction.Price = int.Parse(reader["Price"].ToString());
                        }
                    }
                }
                return direction;
            }
        }
    }
}
