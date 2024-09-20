using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

class Var
{
    public static void MyVar()
    {
        string MyName = "Sheldon";

        Console.WriteLine(MyName);
    }

      public static void DataTypes()
      {
        string firstName = "Sheldon";
        string lastName = "Roberson";
        string wholename = firstName + lastName;
        int age = 16;
        double height = 5.7;
        float gpa = 3.4f;
        decimal dollar = 100.95m;
        bool is_Student = true;
        char grade = 'f';

       // Console.WriteLine(firstName);
        //Console.WriteLine(lastName);
        Console.WriteLine(wholename);
        Console.WriteLine(age);
        Console.WriteLine(height);
        Console.WriteLine(gpa);
        Console.WriteLine(dollar);
        Console.WriteLine(is_Student);
        Console.WriteLine(grade);
        
      }
}