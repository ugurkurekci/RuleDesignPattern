using Models;
using Rules.Abstracts;

namespace Rules.Concretes;

public class MonthlyIncomRule : IEntitledRule
{
    public bool CheckScholarship(Student student)
    {

        if (student.MonthlyIncome<=999)
        {

            return true;

        }

        Console.WriteLine("Kişinin aylık geliri 999 Liranın altında olmalıdır.");
        return false;

    }
}