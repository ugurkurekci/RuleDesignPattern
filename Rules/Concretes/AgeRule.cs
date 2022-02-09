using Models;
using Rules.Abstracts;

namespace Rules.Concretes;

public class AgeRule : IEntitledRule
{
    public bool CheckScholarship(Student student)
    {

        if (student.Age>=18 && student.Age<=28)
        {

            return true;

        }

        Console.WriteLine("18 ile 28 yaş aralığında olmanız gerekmektedir.");
        return false;

    }
}