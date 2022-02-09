using Models;
using Rules.Abstracts;

namespace Rules.Concretes;

public class HouseholdIncomeRule : IEntitledRule
{
    public bool CheckScholarship(Student student)
    {

        return student.HouseholdIncome<=4250;

    }
}