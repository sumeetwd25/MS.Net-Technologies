using HR;

Console.WriteLine("Before Person object is created");

//Apply disposing technique
using(Person p1 = new Person{FirstName="Peter", LastName="Parker"}){
    Console.WriteLine(p1);
}

Console.WriteLine("After person work is finished");

GC.Collect();