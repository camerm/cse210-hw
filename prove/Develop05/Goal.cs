using System;

public class Goal
{
    private string _nameGoal;
    private string _descriptionGoal;
    private bool _concluded = false;
    private int _pointsGoal;


    public Goal()
    {
        

    }

    
    public string GetNameGoal()
    {
        return _nameGoal;
    }
    public void SetNameGoal(string nameGoal)
    {
        _nameGoal = nameGoal;
    }

    public string GetDescriptionGoal()
    {
        return _descriptionGoal;
    }
    public void SetDescriptionGoal(string descriptionGoal)
    {
        _descriptionGoal = descriptionGoal;
    }
    
    public bool GetConcluded()
    {
        return _concluded;
    }
    public void SetConcluded(bool concluded)
    {
        _concluded = concluded;
    }
    
    public int GetPointsGoal()
    {
        return _pointsGoal;
    }
    public void SetPointsGoal(int pointsGoal)
    {
        _pointsGoal = pointsGoal;
    }



    public virtual string SaveGoal()
    {
        return $"simple goal: {_nameGoal}, {_descriptionGoal}, {_pointsGoal}";
    }


    public virtual int RecordEvent()
    {
        _concluded = true;
        Console.WriteLine($"Congratulations. You have earned {_pointsGoal} points.");
        return _pointsGoal;
    }
    public void IsComplete()
    {
        _nameActivity = nameActivity;
    }
}