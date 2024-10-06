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
    public class RepasitoriConteiner : IRepasitori<Cantainer, RequesCantainer>
    {
        public const string CS = "Data Source=.;Initial Catalog = CarsDb; Integrated Security = True; Encrypt=False";
        public void Addd(Cantainer t)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Canteiner values (@Id,@Open,@Caficent)";
                    command.Parameters.Add(new SqlParameter("@Id", t.Id));
                    command.Parameters.Add(new SqlParameter("@Open", t.Open));
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
                    command.CommandText = "DELETE FROM Canteiner WHERE Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", Id));

                    command.ExecuteNonQuery();
                }
            }
        }

        public Cantainer GetById(int Id)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                Cantainer cantainer = new Cantainer();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Canteiner where Id = @Id";
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

        public List<Cantainer> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                List<Cantainer> cantainers = new List<Cantainer>();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Canteiner";

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

        public void Updatee(Cantainer t)
        {
            using(SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Canteiner set Open = @Open,Caficent = @Caficent where Id = @Id";
                    command.Parameters.Add(new SqlParameter("@Id", t.Id));
                    command.Parameters.Add(new SqlParameter("@Open", t.Open));
                    command.Parameters.Add(new SqlParameter("@Caficent",t.Caficent));

                    command.ExecuteNonQuery();
                }
            }
        }
        public Cantainer Find(RequesCantainer request)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();

                Cantainer cantainer = new Cantainer();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Canteiner where Open = @Open";
                    command.Parameters.Add(new SqlParameter("@Open", request.Open));

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
    }
}
