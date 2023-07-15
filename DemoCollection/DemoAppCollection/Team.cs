namespace ICC;

public class Team{
    private List<Player> _players = new List<Player>();
    public Team(){
        this._players.Add(new Player{Name="Sachin",Score=10000});
        this._players.Add(new Player{Name="Dhoni",Score=9000});
        this._players.Add(new Player{Name="Virat",Score=8000});
        this._players.Add(new Player{Name="Rohit",Score=7000});
        this._players.Add(new Player{Name="Dhawan",Score=6000});
    }

    //Indexer
    public Player this[int index]{
        get{return this._players[index];}
        set{this._players[index]=value;}
    }
}