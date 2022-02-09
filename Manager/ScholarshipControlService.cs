using Models;
using Rules.Abstracts;
using Rules.Concretes;

namespace Manager;

public class ScholarshipControlService
{
    private readonly List<IEntitledRule> _rules = new List<IEntitledRule>();

    public ScholarshipControlService()
    {

        _rules.Add(new AgeRule());

        _rules.Add(new MonthlyIncomRule());

        _rules.Add(new HouseholdIncomeRule());

        _rules.Add(new EducationLevelRule());

    }

    public bool Control(Student student)
    {

        var isEntitled = true;

        foreach (var rule in _rules)
        {

            isEntitled = rule.CheckScholarship(student);

            if (!isEntitled)
            {
                break;
            }
        }

        return isEntitled;
    }
}