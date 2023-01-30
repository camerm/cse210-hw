using System;

public class ReflectingActivity : Activity
{
    private List<string> prompt;
    private List<string> questions;

    public ReflectingActivity() : base()
    {
        SetnameActivity("Reflecting Activity");
        SetdescriptionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
        prompt = new List<string>
        {
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless",
        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?";
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }

    public void runActivity()
    {
        runActivityParentStart();
        displayPrompt();
        displayQuestion();
        runActivityParentEnd();
    }

    public void displayPrompt()
    {
        Console.Clear();
        Console.writeLine("Consider the following: ");

        int ramdomIndex = new ramdom().Next(0, prompt.Count());
        Console.writeLine(prompt[ramdomIndex]);

        Console.writeLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        
    }

    public void displayQuestion()
    {
        console.writeLine("Now ponder on each of the following question as they relate to this experience");
        displayCountDown(5);

        console.Clear();
        List<int> indexes = new List<int>();

        for (int i = 0, i < 4; i++)
        {
            int ramdomInt = new Random().Next(0, question.Count());
            while (indexes.Contains(ramdomInt))
            {
                ramdomInt = new Random().Next(0, question.Count());
            }
            indexes.Add(ramdomInt);   
        }
        foreach (int index in indexes)
        {
            Console.writeLine(question[index]);
            displaySpinner((userSessionLengthInput / indexes.(count())));
            Console.writeLine();
        }


    }
}