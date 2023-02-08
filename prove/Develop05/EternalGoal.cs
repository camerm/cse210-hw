using System;

public class EternalGoal : Goal
{
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulation. You have earned {GetPointsGoal()} points.");
        return GetPointsGoal();
    }
    public override string SaveGoal()
    {
        return $"Eternal Goal: {GetNameGoal()}, {GetDescriptionGoal()}, {GetPointsGoal()}";
    }
}