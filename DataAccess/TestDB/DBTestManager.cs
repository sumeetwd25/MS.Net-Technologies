namespace Testing;
using HR;
using MySql.Data.MySqlClient;

public class DBTestManager
{
    //Database connectivity code
    public static string conString = @"server=192.168.10.150; port=3306; user=dac39; password=welcome; database=dac39";
    public static List<Department> GetAllDepartments()
    {
        List<Department> allDepartments = new List<Department>();
        //MySqlConnection : establishing connection
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try
        {
            con.Open();
            //MySqlCommand : query execution
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            //Fire query to database
            string query = "select * from departments";
            cmd.CommandText = query;
            //MySqlDataReader : Result of the query to be captured after processing query
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

    public static Department GetDepartmentDetails(int _id)
    {
        Department dept = null;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "select * from departments where id=" + _id;
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string location = reader["location"].ToString();

                dept = new Department
                {
                    Id = id,
                    Name = name,
                    Location = location
                };
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return dept;
    }

    public static bool Insert(Department dept)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        bool status = false;
        string query = "insert into departments(name, location) values('" + dept.Name + "','" + dept.Location + "')";

        try
        {
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();  //DML
            status = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return status;
    }

    public static bool Update(Department dept)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        bool status = false;

        try
        {
            string query = "update departments set name='" + dept.Name + "',location='" + dept.Location + "' where id=" + dept.Id;

            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();  //DML
            status = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return status;
    }

    public static bool Delete(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        bool status = false;

        try
        {
            string query = "delete from departments where id=" + id;

            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();  //DML
            status = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return status;
    }
}


