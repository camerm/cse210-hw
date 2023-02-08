using System;

class Program
{
    static void Main(string[] args)
    {
        int menuInput = 0;
        int puntuation = 0;
        int counter1 = 0;
        int UserTypeGoal = 0;
        string _inlist;
        int counter2 = 1;
        
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
        
        List <string> typesGoal = new List<string>
        {
            "The types of goal are:",
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal",
        };


        List<Goal> goals = new List<Goal>();


        while (menuInput !=6)
        {
            Console.Clear();
            Console.WriteLine($"You have {puntuation} points.");

            foreach (string menuOption in menu)
            {
                Console.WriteLine(menuOption);                
            }
            Console.Write("Select a option from the menu: ");
            menuInput = int.Parse(Console.ReadLine());
        
        
            switch (menuInput)
            {
                case 1:
                    foreach (string types in typesGoal)
                    {
                        Console.WriteLine(types);
                    }
                    Console.Write("Which type of goal would you like to create?: ");
                    UserTypeGoal = int.Parse(Console.ReadLine());

                    switch (UserTypeGoal)
                    {
                        case 1:
                        goals.Add(new Goal());
                        goals[counter1].QuestionsOfGoals();
                        break;

                        case 2:
                        goals.Add(new EternalGoal());
                        goals[counter1].QuestionsOfGoals();
                        break;

                        case 3:
                        goals.Add(new ChecklistGoal());
                        goals[counter1].QuestionsOfGoals();
                        break;
                    }
                counter1++;
                break;
                
                case 2:
                    Console.Clear();



                    Console.WriteLine("The goals are: ");

                    foreach (Goal goal in goals)
                    {
                        _inlist = goal.MakingListGoal();
                        Console.WriteLine($"{counter2}, {_inlist}");
                        counter2++;
                    }
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("What is the filename of your goal file?: ");

                    string fileName = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine(puntuation);
                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.SaveGoal());
                        }
                    }

                    break;
                case 4:
                    Console.WriteLine("What is the filename for the goal file?: ");

                    fileName = Console.ReadLine();

                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    int counter3 = 0;

                    puntuation = int.Parse(lines[0]);

                    foreach (string line in lines)
                    {
                        if (line != lines[0])
                        {
                            string[] parts = line.Split(":");
                            
                            string goalType = parts[0];
                            string goalAttributes = parts[1];
                                
                            switch (goalType)
                            {
                                case "SimpleGoal":
                                        
                                    string[] attributes = goalAttributes.Split(",");
                                    goals.Add(new Goal());
                                    goals[counter3].FactoryPattern(attributes);
                                    counter3++;
                                    break;

                                case "EternalGoal":
                                        
                                    attributes = goalAttributes.Split(",");
                                    goals.Add(new EternalGoal());
                                    goals[counter3].FactoryPattern(attributes);
                                    counter3++;
                                    break;
                                    
                                case "CheckListGoal":
                                        
                                    attributes = goalAttributes.Split(",");
                                    goals.Add(new ChecklistGoal());
                                    goals[counter3].FactoryPattern(attributes);
                                    counter3++;
                                    break;    
                            }
                        }
                            
                    }  
                    
                    counter1 += counter3;

                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }
    }
}