namespace HR;

public class Person:IDisposable{
    public Person(){}
    public string FirstName{get; set;}
    public string LastName{get; set;}

    public override string ToString(){
        return base.ToString()+" "+FirstName+" "+LastName;
    } 

    public void Dispose(){
        //Releasing resources which have been allocated during lifetime of this object
        Console.WriteLine("Resources are released instantly");
        GC.SuppressFinalize(this);
    } 
    ~Person(){
        //Releasing resources which have been allocated during lifetime of this object
    }
}