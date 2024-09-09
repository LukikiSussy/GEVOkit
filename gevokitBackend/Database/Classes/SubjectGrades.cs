namespace gevokitBackend.Database.Classes;

public class SubjectGrades
{
    public required string Subject { get; set; }

    private List<float>? grades;
    public List<float>? Grades
    {
        get { return grades; }

    }
    public void AddGrade(float grade)
    {
        if (grade < 0 || grade > 100) return;

        if (grades == null) grades = new List<float>();

        grades.Add(grade);
    }

    public void RemoveGrade(int index)
    {
        if (grades == null) return;
        if (index >= grades.Count) return;

        grades.RemoveAt(index);
    }
}