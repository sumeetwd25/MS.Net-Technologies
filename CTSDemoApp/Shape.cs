namespace Drawing;
 public abstract class Shape{

    //All the letters in const variable should be capital
    public const double PI=3.14;

    public string color;
    public int width;

    public Shape(){
        this.color="Black";
        this.width=3;
    }

    public Shape(string c, int w){
        this.color=c;
        this.width=w;
    }

    public abstract void Draw();

    public virtual void Display(){
        Console.WriteLine("Width="+width+", Color="+color);
    }
 }