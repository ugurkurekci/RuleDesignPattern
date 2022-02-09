using Models;
using Rules.Abstracts;

namespace Rules.Concretes;

public class HouseholdIncomeRule : IEntitledRule
{
    public bool CheckScholarship(Student student)
    {

        if (student.HouseholdIncome<=4250)
        {

            return true;

        }

        Console.WriteLine("Evin aylık geliri 4250 Liranın altında olmalıdır.");
        return false;
    }
}