using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Allgoals _allgoals = new Allgoals();
        int _userselect = 0; 

        while (_userselect != 6)
        {
            _allgoals.DisplayPoints();
            _userselect = menu.DisplayMainMenu();

            switch (_userselect)
            {
                case 1:
                    int _newselection = menu.DisplayGetNewGoal();
                    Goal goal = null;
                    switch (_newselection)
                    {
                        case 1:
                            goal = new SimpleGoal();
                            goal.DisplayGetName();
                            goal.DisplayGetDescription();
                            goal.DisplayGetGoalPoint();
                            break;
                        case 2:
                            goal = new EternalGoal();
                            goal.DisplayGetName();
                            goal.DisplayGetDescription();
                            goal.DisplayGetGoalPoint();
                            break;
                        case 3:
                            goal = new CheckListGoal();
                            // goal.DisplayGetName();
                            // goal.DisplayGetDescription();
                            // goal.DisplayGetGoalPoint();
                            break;
                    }
                    if (goal != null)
                    {
                        _allgoals.AddGoal(goal);
                    }
                    break;
                case 2:
                    // Allgoals lists = new Allgoals();
                    _allgoals.DisplayGoals();
                    break;
                case 3:
                    // Allgoals saves = new Allgoals();
                    _allgoals.SaveGoals();
                    break;
                case 4:
                    // Allgoals loads = new Allgoals();
                    _allgoals.LoadGoals();
                    break;
                case 5:
                    // Allgoals records = new Allgoals();
                    _allgoals.Records();
                    break;
            }
        }


        
    }
}