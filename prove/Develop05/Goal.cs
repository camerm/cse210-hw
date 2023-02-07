using System;

public class Goal
{
    private string _nameGoal;
    private string _descriptionGoal;


    public Goal()
    {
        

    }

    
    public string GetnameGoal()
    {
        return _nameGoal;
    }
    public void SetnameGoal(string nameGoal)
    {
        _nameGoal = nameGoal;
    }

    public string GetdescriptionGoal()
    {
        return _descriptionGoal;
    }
    public void SetdescriptionGoal(string descriptionGoal)
    {
        _descriptionGoal = descriptionGoal;
    }



    public virtual string SaveGoal()
    {
        return $"simple goal: {_nameGoal}, {_descriptionGoal}";
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