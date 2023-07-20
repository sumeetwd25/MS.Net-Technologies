namespace Testing;
using HR;
using MySql.Data.MySqlClient;

public class DBTestManager
{
    public static string conString = @"server=192.168.10.150; port=3306; user=dac39; password=welcome; database=dac39";
    public static List<Department> GetAllDepartments()
    {
        List<Department> allDepartments = new List<Department>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try
        {
            con.Open();
            //Fire query to database
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string query = "select * from departments";
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string location = reader["location"].ToString();

                Department dept = new Department
                {
                    Id = id,
                    Name = name,
                    Location = location
                };
                allDepartments.Add(dept);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }

        return allDepartments;
    }
}


