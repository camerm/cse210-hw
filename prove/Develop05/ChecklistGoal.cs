using System;

public class ChecklistGoal : Goal
{


public override void QuestionsOfGoals()
{
    AskName();
    AskDescription();
    AskGoalPoints();
}

}


