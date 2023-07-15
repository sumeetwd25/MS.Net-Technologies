namespace ICC;

public class Player{
    public string Name{get; set;}
    public int Score{get; set;}

    public override string ToString()
    {
        return base.ToString()+" Name:"+Name+" Score:"+Score;
    }
}