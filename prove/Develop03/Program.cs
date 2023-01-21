using System;

class Program
{
    static void Main(string[] args)
    {
        Reference passage = new Reference("Isaiah", 1, 18);
        Scripture scripture = new Scripture("Come now, and let us areason together, saith the Lord: though your bsins be as scarlet, they shall be as cwhite as snow; though they be red like crimson, they shall be as wool.");
        Console.WriteLine(passage.getReference());
        Console.WriteLine(scripture.getScripture());
        Console.WriteLine();

    }

}