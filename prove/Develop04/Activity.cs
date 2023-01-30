using System;

public class Activity
{
    private string _nameActivity;
    private string _desciptionActivity;
    private string _startingMessage;
    private string _endingMessage;

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
        console.writeLine(string.Format("Welcome to the {0}.", nameActivity));
        console.writeLine();
        console.writeLine(descriptionActivity);
        console.writeLine();

        console.write("How long in seconds, would your like for your seasons? ");
        userSessionLengthInput = int.Parse(console.writeLine());

        console.writeLine("get ready...");
        displaySpinner(5);
    }
    public void runActivityParentEnd()
    {
        console
    }

    public void displaySpinner()
    {

    }
    public void displayCountDown()
    {

    }


}