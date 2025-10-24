namespace CFFTaskUserNew;

public class Admin : User
{
   public bool isSuperAdmin;
   public string section;

   public Admin(string Name, string Password, string Email) : base(Name, Password, Email)
   {
      isSuperAdmin=true;
      while (true)
      {
         Console.WriteLine("Section daxil ele");
         string inputSection=Console.ReadLine();
    
         if (string.IsNullOrWhiteSpace(inputSection))
         {
            Console.WriteLine("Section duzgun daxil et");
         }
         else
         {
            section=inputSection;
            break;
         }
         
      }

      
      
   }
   public void PrintAll()
   {
      Console.WriteLine($"Ad: {Name} --\n Kod: {Password}\n Email {Email} --\n SuperAdmin{isSuperAdmin}\n section {section}");
   }
}
