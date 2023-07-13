namespace Drawing;

//If the method is sealed, it cannot be overrided.
public sealed class Line:Shape{     //: is similar to extends in java
    public Point startPoint;
    public Point endPoint;

    //Constructor overloading
    //Static polymorphism
    public Line():base(){           //base is similar to super() in java
        this.startPoint=new Point(1,4);
        this.endPoint=new Point(45,67);
    }

    public Line(Point pt1, Point pt2, string c, int w):base(c,w){
        this.startPoint=pt1;
        this.endPoint=pt2;
        this.color=c;
        this.width=w;
    }

    //Method overriding
    //Runtime polymorphism
    public override void Draw()
    {
        Console.WriteLine("Drawing Line");
        Console.WriteLine(this.color+" "+this.width+" "+"("+this.startPoint.x+","+this.startPoint.y+"),("+this.endPoint.x+","+this.endPoint.y+")");
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("("+this.startPoint.x+","+this.startPoint.y+"),("+this.endPoint.x+","+this.endPoint.y+")");
    }
}