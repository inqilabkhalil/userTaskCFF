namespace CFFTaskUserNew;

public class User
{
    public string Name;
    public string Password;
    public string Email;

    public User()
    {
        
    }
    public User(string name, string password, string email)
    {
        Name=name;
        Password=password;
        Email=email;
    }
    public void SetName()
    {
        while (true)
        {
            Console.WriteLine("Adi daxil edin:");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || name.Length < 6)
            {
                Console.WriteLine("Adi duzgun daxil edin");
            }
            else
            {
                Name = name;
                break;
            }
        }
    }

    public bool CheckUpper(string word)
    {
        foreach (char c in word)
        {
            if (char.IsUpper(c))
                return true;
        }
        return false;
    }

    public void SetPassword()
    {
        while (true)
        {
            Console.WriteLine("Password daxil edin:");
            string password = Console.ReadLine();

            if (CheckUpper(password) && password.Length >= 6)
            {
                Password = password;
                break;
            }
            else
            {
                Console.WriteLine("Passwordu duzgun daxil edin");
            }
        }
    }

    public void SetEmail()
    {
        while (true)
        {
            Console.WriteLine("Email daxil edin:");
            string email = Console.ReadLine();

            if (!string.IsNullOrEmpty(email) &&
                email.Contains('@') &&
                email.IndexOf('@') != 0 &&
                email.IndexOf('@') != email.Length - 1)

            {
                Email = email;
                break;
            }
            else
            {
                Console.WriteLine("Email duzgun daxil edilmeyib.");
            }
        }
    }
}