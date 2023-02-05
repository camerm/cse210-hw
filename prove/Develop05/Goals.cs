using System;

public class Goals
{
    private string _nameActivity;
    private string _desciptionActivity;
    private string _startingMessage;
    private string _endingMessage;
    static int userSessionLengthInput = 0;
    static int spinnerCounter = 0;

    public Goals()
    {
        spinnerCounter = userSessionLengthInput = 0;

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