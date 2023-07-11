namespace HR;

public class Person{
    //data members
    private string firstName;
    public void SetFirstName(string name){
        this.firstName=name;
    }
    public string GetFirstName(){
        return this.firstName;
    }

    private string lastName;
    //Property LastName VB syntax
    public string LastName{
        get{return this.lastName;}
        set{this.lastName=value;}
    }

    private String email;
    public string Email{
        get{return this.email;}
        set{this.email=value;}
    }

    private string contactNumber;
    private DateTime birthDate;

//member functions
//constructor overloading

public Person(){
    this.firstName="Peter";
    this.lastName="Parker";
    this.birthDate=new DateTime(1991,01,01);
    this.email="peter.parker@mcu.com";
    this.contactNumber="9876543210";
}

public Person(string fName, string lName, DateTime bDate, string email, string contact){
    this.firstName=fName;
    this.lastName=lName;
    this.birthDate=bDate;
    this.email=email;
    this.contactNumber=contact;
}

~Person(){
    //Logic for releasing resources during lifetime of object.
    //It will be automatically called by garbage collector.
}

public override string ToString(){
    return this.firstName+" "+this.lastName;
}

}
