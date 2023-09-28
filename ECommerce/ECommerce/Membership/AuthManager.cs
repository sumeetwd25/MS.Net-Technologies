namespace Membership;

public class AuthManager
{
    public static bool Validate(string email, string password){
        bool status = false;
        if(email=="sumeet@iet.com" && password=="123"){
            status = true;
        }
        return status;
    }

    public static bool Register(string email, string password){
        bool status = false;

        // Store credentials into storage.

        return status;
    }
}
