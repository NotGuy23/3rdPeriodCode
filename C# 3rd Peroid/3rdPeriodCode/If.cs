class If
{
    public static void IfElse(int number)
    {
        
        
        if(number > 0)
        {
          Console.WriteLine("The Number is Positive");
        }
        else if(number < 0)
        {
          Console.WriteLine("The Number is Negative");
        }
        else
        {
            Console.WriteLine("Your Number is 0");
        }

    } public static void Health(int health)
    {
         if(health > 75)
        {
          Console.WriteLine("The Player is in Great Condition");
        }
        else if(health > 50)
        {
          Console.WriteLine("The Player is in Good Condintion");
        }
        else if (health > 0)
        {
            Console.WriteLine("The Player is in Danger");
        }
        else
        {
            Console.WriteLine("Game Over");
        }
    }
}