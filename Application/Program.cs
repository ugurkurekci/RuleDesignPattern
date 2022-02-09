using Manager;
using Models;

var student = new Student
{
    EducationLevels=Models.Enums.EducationLevel.Lisans,
    Age=24,
    HouseholdIncome=15000,
    MonthlyIncome=8000
};

var calculator = new ScholarshipControlService();
bool isEntitled = calculator.Control(student);

Console.WriteLine($"Sonuc {isEntitled}");

/*Yukardaki senaryoya göre öğrenciye burs verilmeyecek.*/
