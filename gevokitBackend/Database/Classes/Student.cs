namespace gevokitBackend.Database.Classes;

public class Student
{
    public int StudentId { get; set; }
    public required string Name { get; set; }
    public required string Surename { get; set; }
    public string? Class { get; set; }
    //public List<SubjectGrades>? Grades { get; set; } //not finished, create "AddGrade(string Subject, float Grade) {}" method
    public int[] Ints{ get; set; }
    public required string? Email { get; set; }

}