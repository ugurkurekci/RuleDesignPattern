using Models;
using Models.Enums;
using Rules.Abstracts;

namespace Rules.Concretes
{
    public class EducationLevelRule : IEntitledRule
    {

        public bool CheckScholarship(Student student)
        {

            if (student.EducationLevels==EducationLevel.YüksekLisans)
            {

                return true;

            }

            else if (student.EducationLevels==EducationLevel.Lisans)
            {

                return true;

            }

            else if (student.EducationLevels==EducationLevel.Önlisans)
            {

                return true;

            }

            Console.WriteLine("Eğitim seviyesi şartlara uymamaktadır. En az Önlisans mezunu olmak zorundasınız.");
            return false;

        }
    }
}