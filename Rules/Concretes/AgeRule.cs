using Models;
using Rules.Abstracts;

namespace Rules.Concretes;

public class AgeRule : IEntitledRule
{
    public bool CheckScholarship(Student student)
    {

        return student.Age>=18 && student.Age<=28;

    }
}