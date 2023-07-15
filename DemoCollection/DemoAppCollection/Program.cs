using HR;
using ICC;
using System.Collections.Generic;

 int[] marks = {76,70,55,65,89};
Array.Sort(marks);
Array.Reverse(marks);

foreach(int m in marks){
    Console.WriteLine(m);
}
/*
string [] names = {"Goku", "Vegeta", "Android 17"};
foreach(string n in names){
    Console.WriteLine(n);
}

Person [] people = {
    new Person{FirstName="Naruto", LastName="Uzumaki"},
    new Person{FirstName="Sasuke", LastName="Uchiha"},
    new Person{FirstName="Sakura", LastName="Haruno"}
};

Person p1 = people[1];
Console.WriteLine(p1);

foreach(Person p in people){
    Console.WriteLine(p);
} 

//Rectangular array
int[,] matrix = new int[2,3]{ {12,13,14}, {21,31,41} };
for(int i=0; i<2; i++){
    for(int j=0; j<3; j++){
        Console.WriteLine(matrix[i,j]);
    }
}
 
//Jagged array
//Array of arrays
int [][] dacMarks = new int[3][];
dacMarks[0] = new int [4]{25,27,30,31};
dacMarks[1] = new int [3]{26,27,27};
dacMarks[2] = new int []{67,79,86,35,75,45,56};

for(int i=0; i<dacMarks.Length; i++){
    for(int j=0; j<dacMarks[i].Length; j++){
        Console.WriteLine(dacMarks[i][j]);
    }
}

List<Person> students = new List<Person>();
students.Add(new Person{FirstName="Peter", LastName="Parker"});
students.Add(new Person{FirstName="Tony", LastName="Stark"});

foreach(Person s in students){
    Console.WriteLine(s);
}

Dictionary<string, Person> pgDacStudents = new Dictionary<string, Person>();
pgDacStudents.Add("ceo", new Person{FirstName="Bruce", LastName="Wayne"});
pgDacStudents.Add("cto", new Person{FirstName="Clark", LastName="Kent"});

Person pceo = pgDacStudents["ceo"];
Console.WriteLine(pceo);

Stack<string> callerStudents = new Stack<string>();
callerStudents.Push("Ash");
callerStudents.Push("Brock");
callerStudents.Push("Misty");

string theStudent = callerStudents.Pop();
// Console.WriteLine(theStudent);
foreach(string cs in callerStudents){
    Console.WriteLine(cs);
}


Team teamIndia = new Team();
Player thePlayer = teamIndia[1];    //Indexer   //It is needed where reference object behaves as an array
Console.WriteLine(thePlayer);

thePlayer.Name="Manish";
Console.WriteLine(thePlayer);

teamIndia[1] = new Player{Name="VVS Laxman", Score=27489};
Player thePlayer1 = teamIndia[1];
Console.WriteLine(thePlayer1);

//Type casting
Player pp = new Player{Name="Kakashi Hatake", Score=9999999};
object o = pp;  //Implicit type casting

Player gg = (Player) o; //Explicit type casting

Player kk = o as Player;    //C# syntax of type casting

if(kk is Player){
    Console.WriteLine(kk);
}
else{
    Console.WriteLine("Not found");
}*/