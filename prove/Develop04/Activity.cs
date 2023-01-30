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

}