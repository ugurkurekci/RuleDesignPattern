using Models;
using Rules.Abstracts;

namespace Rules.Concretes;

public class MonthlyIncomRule : IEntitledRule
{
    public bool CheckScholarship(Student student)
    {

        return student.MonthlyIncome<=999;

    }
}