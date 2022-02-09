using Manager;
using Models;

var student = new Student
{
    EducationLevels=Models.Enums.EducationLevel.MastersDegree,
    Age=24,
    HouseholdIncome=4250,
    MonthlyIncome=999
};

var calculator = new ScholarshipControlService();
bool isEntitled = calculator.Control(student);

Console.WriteLine($"Result :  {isEntitled}");

/*Scholarships will not be awarded to students in the above scenario.*/