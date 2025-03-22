namespace RegNisit.Models;
public class CourseModel
{
    public string CourseCode { get; set; }
    public string CourseName { get; set; }
    public string Schedule { get; set; }
    public string Room { get; set; }
    public int AcademicYear { get; set; }  // ปีการศึกษา
    public string Semester { get; set; }  // ภาคเรียน (1, 2, ฤดูร้อน)
}