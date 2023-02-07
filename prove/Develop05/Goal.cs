using System;

public class Goal
{
    private List<string> Goal;
    private List<string> GoalTypes;
    private string _nameActivity;
    static int userSessionLengthInput = 0;

    public Goal()
    {
        spinnerCounter = userSessionLengthInput = 0;

    }

    public void CreateNewGoal()
    {
        Console.WriteLine("Select a choices from the menu: ");

        List <string> GoalTypes = new List<string>
        {
        "Menu option:",
        "1. Simple Goal",
        "2. Eternal Goal",
        "3. Checklist Goal",
        };
    }

    public void SaveGoal()
    {
        Console.WriteLine("Select a choices from the menu: ");

        List <string> GoalTypes = new List<string>
        {
        "Menu option:",
        "1. Simple Goal",
        "2. Eternal Goal",
        "3. checklist Goal",
        };
    }

    public void LoadGoal()
    {
        Console.WriteLine("Select a choices from the menu: ");

        List <string> GoalTypes = new List<string>
        {
        "Menu option:",
        "1. Simple Goal",
        "2. Eternal Goal",
        "3. checklist Goal",
        };
    }

    public void RecordEvent( string nameActivity)
    {
        _nameActivity = nameActivity;
    }
    public void IsComplete( string nameActivity)
    {
        _nameActivity = nameActivity;
    }
}