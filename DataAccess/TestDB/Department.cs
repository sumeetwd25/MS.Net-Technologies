namespace HR;

public class Department
{

    public int Id { get; set; }        //primary key in database
    public string? Name { get; set; }  //nullable type
    public string? Location { get; set; }

    public Department()
    {

    }

    public Department(string dname, string dloc)
    {
        this.Name = dname;
        this.Location = dloc;
    }

    public Department(int id, string dname, string dloc)
    {
        this.Id = id;
        this.Name = dname;
        this.Location = dloc;
    }
}
