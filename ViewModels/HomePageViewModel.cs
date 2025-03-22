using System.Collections.ObjectModel;
using System.ComponentModel;
using RegNisit.Models;

namespace RegNisit.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string WelcomeMessage { get; set; } = "Welcome back, Singharat Bunphim!";

        public ObservableCollection<CourseModel> Courses { get; set; }

        public HomePageViewModel()
        {
            Courses = new ObservableCollection<CourseModel>
            {
                new CourseModel
                {
                    CourseCode = "1204305: Computer Graphics",
                    CourseName = "คอมพิวเตอร์กราฟิก",
                    Schedule = "(C) 21 มี.ค. 2568 | 13:00-16:00",
                    Room = "ห้องเรียน: IT-412 (10)",
                    AcademicYear = 2567,
                    Semester = "2"
                },
                new CourseModel
                {
                    CourseCode = "1204306: Software Engineering",
                    CourseName = "วิศวกรรมซอฟต์แวร์",
                    Schedule = "(C) 19 มี.ค. 2568 | 13:00-16:00",
                    Room = "ห้องเรียน: IT-412 (23)",
                    AcademicYear = 2568,
                    Semester = "2"
                },
                new CourseModel
                {
                    CourseCode = "1204307: Artificial Intelligence",
                    CourseName = "ปัญญาประดิษฐ์",
                    Schedule = "(L) 25 มี.ค. 2568 | 13:00-16:30",
                    Room = "ห้องเรียน: IT-401 (11)",
                    AcademicYear = 2568,
                    Semester = "2"
                },
                new CourseModel
                {
                    CourseCode = "1204407: Machine Learning",
                    CourseName = "การเรียนรู้ของเครื่อง",
                    Schedule = "(L) 24 มี.ค. 2568 | 08:00-17:00",
                    Room = "ห้องเรียน: IT-402 (8)",
                    AcademicYear = 2568,
                    Semester = "2"
                },
                new CourseModel
                {
                    CourseCode = "1204433: Cross Platform Mobile App",
                    CourseName = "พัฒนาโปรแกรมข้ามระบบปฏิบัติการ",
                    Schedule = "(L) 26 มี.ค. 2568 | 12:00-17:00",
                    Room = "ห้องเรียน: IT-401 (7)",
                    AcademicYear = 2568,
                    Semester = "2"
                }
            };
        }
    }
}
