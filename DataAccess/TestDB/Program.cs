using Testing;
using HR;

int ch;
do
{
    Console.WriteLine("\n1.Display all dept\n2.Display by id\n3.Add new dept\n4.Update dept by id\n5.Delete dept by id\n6.Exit");
    Console.Write("Enter choice : ");
    string choice = Console.ReadLine();
    ch = Convert.ToInt32(choice);

    switch (ch)
    {
        case 1:
            List<Department> departments = DBTestManager.GetAllDepartments();
            Console.WriteLine();
            foreach (Department dept in departments)
            {
                Console.WriteLine(dept.Name + " " + dept.Location);
            }
            break;

        case 2:
            Console.Write("\nEnter id : ");
            string id = Console.ReadLine();
            int deptId = Convert.ToInt32(id);
            Department dept1 = DBTestManager.GetDepartmentDetails(deptId);
            Console.WriteLine(dept1.Name + " " + dept1.Location);
            break;

        case 3:
            Console.Write("\nEnter department name : ");
            string dname = Console.ReadLine();
            Console.Write("Enter department location : ");
            string dloc = Console.ReadLine();
            Department dept2 = new Department(dname, dloc);

            bool status = DBTestManager.Insert(dept2);
            if (status == true)
            {
                Console.WriteLine("Department added successfully");
            }
            else
            {
                Console.WriteLine("Department not added");
            }
            break;

        case 4:
            Console.Write("\nEnter department id : ");
            id = Console.ReadLine();
            deptId = Convert.ToInt32(id);
            Console.Write("Enter new department name : ");
            dname = Console.ReadLine();
            Console.Write("Enter new department location : ");
            dloc = Console.ReadLine();
            Department dept3 = new Department(deptId, dname, dloc);

            status = DBTestManager.Update(dept3);
            if (status == true)
            {
                Console.WriteLine("Department updated successfully");
            }
            else
            {
                Console.WriteLine("Department not found");
            }
            break;

        case 5:
            Console.Write("\nEnter department id : ");
            id = Console.ReadLine();
            deptId = Convert.ToInt32(id);

            status = DBTestManager.Delete(deptId);
            if (status == true)
            {
                Console.WriteLine("Department deleted successfully");
            }
            else
            {
                Console.WriteLine("Department not found");
            }
            break;

        case 6:
            Console.WriteLine("\nThankyou");

            break;

        default:
            Console.WriteLine("\nInvalid choice");
            break;
    }
} while (ch != 6);


/* 
//Get all departments
List<Department> departments = DBTestManager.GetAllDepartments();
foreach (Department dept in departments)
{
    Console.WriteLine(dept.Name + " " + dept.Location);
}


//Get department by id
Console.Write("Enter id : ");
string id = Console.ReadLine();
int deptId = Convert.ToInt32(id);
Department dept1 = DBTestManager.GetDepartmentDetails(deptId);
Console.WriteLine(dept1.Name + " " + dept1.Location);


//Insert department
Console.Write("Enter department name : ");
string dname = Console.ReadLine();
Console.Write("Enter department location : ");
string dloc = Console.ReadLine();
Department dept2 = new Department(dname, dloc);

bool status = DBTestManager.Insert(dept2);
if (status == true)
{
    Console.WriteLine("Department added successfully");
}
else
{
    Console.WriteLine("Department not added");
}


//Update department
Console.Write("Enter department id : ");
string id = Console.ReadLine();
int deptId = Convert.ToInt32(id);
Console.Write("Enter new department name : ");
string dname = Console.ReadLine();
Console.Write("Enter new department location : ");
string dloc = Console.ReadLine();
Department dept3 = new Department(deptId, dname, dloc);

bool status = DBTestManager.Update(dept3);
if (status == true)
{
    Console.WriteLine("Department updated successfully");
}
else
{
    Console.WriteLine("Department not found");
}


//Delete department
Console.Write("Enter department id : ");
string id = Console.ReadLine();
int deptId = Convert.ToInt32(id);

bool status = DBTestManager.Delete(deptId);
if (status == true)
{
    Console.WriteLine("Department deleted successfully");
}
else
{
    Console.WriteLine("Department not found");
} 
*/