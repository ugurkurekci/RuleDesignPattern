using Manager;
using Models;

var student = new Student
{
    EducationLevels=Models.Enums.EducationLevel.BachelorDegree,
    Age=24,
    HouseholdIncome=14000,
    MonthlyIncome=5000
};

var calculator = new ScholarshipControlService();
bool isEntitled = calculator.Control(student);

Console.WriteLine($"Result :  {isEntitled}");

/*Scholarships will not be awarded to students in the above scenario.*/