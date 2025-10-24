namespace CFFTaskUsers;

public class User
{
    string username {get{return username; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 6)
            {
                Console.WriteLine("Daxil etdiyin username yanlisdir");
            }
            else
            {
                username = value;
            }
            
        }
        
    }

    ch
    
    string password
 

    string _email;

}