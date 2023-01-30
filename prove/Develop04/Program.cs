using System;

class Program
{
    static void Main(string[] args)
    {
        int menuInput = 0;
        
        list <string> menu = new list<string>
        {
        "Menu option:",
        "1. Start Beathing Activity",
        "2. Start Refleacting Activity",
        "3. Start Listening",
        "4. Quit",
        };


        while (menuInput != 4)
        {
            Console.clear();
            foreach (string menuOption in menu)
            {
                Console.write(menuOption);                
            }
            Console.write("Select a option from the menu");
            menuInput = int.Parse(Console.ReadLine());
            Console.clear();
        }

        switch (menuInput)
        {
            case 1:
                break;
            case 2:
                ReflectingActivity demo = new ReflectingActivity();
                demo.runActivity();
                break;
        }
        

    }
}