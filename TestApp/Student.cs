using HR;           //Similar to import in java. 
// namespace LMS;   //LMS=Learm=ning Management System

public class Student:Person{

    //special members
    //String or string, both are allowed
    private string course;
    private DateTime registrationDate;
    private int prn;

    public Student(){
        this.course="Cdac";
        this.registrationDate=new DateTime(2023,3,1);
        this.prn=123;
    }

    public Student(string fName, string lName, DateTime bDate, string email, string contact, string course, DateTime rDate, int prn){
        
        this.course=course;
        this.registrationDate=rDate;
        this.prn=prn;
    }

    public string Course{
        get{return this.course;}
        set{this.course=value;}
    }

    public DateTime RegistrationDate{
        get{return this.registrationDate;}
        set{this.registrationDate=value;}
    }

    public int Prn{
        get{return this.prn;}
        set{this.prn=value;}
    }

    public override string ToString(){
        return base.ToString()+" "+this.course+" "+this.registrationDate+" "+this.prn;
    }
}