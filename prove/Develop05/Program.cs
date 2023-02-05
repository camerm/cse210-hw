using System;

class Program
{
    static void Main(string[] args)
    {
        int menuInput = 0;
        
        List <string> menu = new List<string>
        {
        "Menu option:",
        "1. Create new Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit",
        };


        while (menuInput !=6)
        {
            Console.Clear();
            foreach (string menuOption in menu)
            {
                Console.Write(menuOption);                
            }
            Console.Write("Select a option from the menu");
            menuInput = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        
        switch (menuInput)
        {
            case 1:
                break;
            case 2:

                break;
        }
    }
}