namespace RegNisit.Models;
using System.Collections.ObjectModel;

public class AcademicYearModel
{
    public int Year { get; set; }
    public List<SemesterModel> Semesters { get; set; } = new();
}

public class SemesterModel
{
    public string SemesterName { get; set; }
    public ObservableCollection<CourseModel> Courses { get; set; } = new();
}