using Models;

namespace Rules.Abstracts;

public interface IEntitledRule
{

    bool CheckScholarship(Student student);

}