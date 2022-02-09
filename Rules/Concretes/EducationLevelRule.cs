using Models;
using Models.Enums;
using Rules.Abstracts;

namespace Rules.Concretes;

public class EducationLevelRule : IEntitledRule
{

    public bool CheckScholarship(Student student)
    {

        switch (student.EducationLevels)
        {

            case EducationLevel.MastersDegree:

            case EducationLevel.BachelorDegree:

            case EducationLevel.AssociateDegree:
                {
                    return true;
                }

            default: break;

        }

        return false;
    }
}