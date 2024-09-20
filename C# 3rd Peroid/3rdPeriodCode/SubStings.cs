class SubStrings
{

    public static void MySubStrings()
    {
        string name = "Spongebob Squarepants";
        
     string sponge = name.Substring(6,3);
     string pat = name.Replace("Spongebob","Patrick");
     string patrick = name.Replace("name","Patrick");
     int index = name.IndexOf("q");


        Console.WriteLine(name);
        Console.WriteLine(sponge);
        Console.WriteLine(pat);
        Console.WriteLine(patrick);
        Console.WriteLine(index);
        Console.WriteLine(name.Length);
    }
}