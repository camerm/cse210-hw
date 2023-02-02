using System;

public class Activity
{
    private string _nameActivity;
    private string _desciptionActivity;
    private string _startingMessage;
    private string _endingMessage;
    static int userSessionLengthInput = 0;
    static int spinnerCounter = 0;

    public Activity()
    {
        spinnerCounter = userSessionLengthInput = 0;

    }
    public void SetnameActivity( string nameActivity)
    {
        _nameActivity = nameActivity;
    }

    public void SetdescriptionActivity(string descriptionActivity)
    {
        _descriptionActivity = descriptionActivity;
    }

    public void runActivityParentStart()
    {
        Console.WriteLine(string.Format("Welcome to the {0}.", nameActivity));
        Console.WriteLine();
        Console.WriteLine(descriptionActivity);
        Console.WriteLine();

        Console.Write("How long in seconds, would your like for your seasons? ");
        userSessionLengthInput = int.Parse(Console.ReadLine());

        Console.WriteLine("get ready...");
        displaySpinner(5);
    }
    public void runActivityParentEnd()
    {
        console
    }

    public void displayEndingMessage()
    {
        _endingMessage = string.Format("You have completed {0} seconds for the {1}.", userSessionLengthInput, activityName);
        Console.WriteLine();
        Console.WriteLine("Well done !!!");
        displaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        Console.WriteLine();
        displaySpinner(3);
    }

    public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        while (stopWatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("°"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write("");
    }
    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >=1; i--)
        Console.WriteLine(String.Format("You may begin in: {0}, i"));
        Console.SetCursorPosition(0, Console.CursorTop);
        Thread.Sleep(1000);
    }


}