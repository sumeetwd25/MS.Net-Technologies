namespace TeamBuilding;

//If the class is singleton, the constructor is private and has static methods.
public class Leader{
    public static int count;

    //readonly variable can be initialized only once in lifetime
    private static Leader _ref;

    private Leader(){
        count++;
    }

    public static Leader GetLeader(){
    if(_ref==null){
        _ref=new Leader();
    }
    return _ref;
    }
}



