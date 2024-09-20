using System.Xml;

class Loops
{
    public static void ForLoops()
    {
        
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }
    }
    public static void EvenLoop()
    {
        for(int i = 1; i <= 20; i++)
        {
           if(i % 2 == 0)
           {
            Console.WriteLine(i);
           }
            
        }
    }
    public static void HealthLoop()
    {
        int health = 100;
        while(health > 0)
        {
           Console.WriteLine("Player is alive with health: " + health);
           health -= 10;
        }
  
  
  }

   public static void NestedLoops()
   {
        for(int i = 0; i <= 3; i++)
        {
            Console.WriteLine("Iteration i: " + i);
            for(int j = 0; j <= 3; j++)
             {
            Console.WriteLine("             Iteration j: " + j);
            }
        }
        
   }

}