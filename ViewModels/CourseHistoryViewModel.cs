using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RegNisit.Models;

namespace RegNisit.ViewModels;

public partial class CourseHistoryViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<AcademicYearModel> availableYears = new();

    [ObservableProperty]
    private AcademicYearModel selectedYear;

    public CourseHistoryViewModel()
    {
        LoadAvailableYears();
    }

    private void LoadAvailableYears()
    {
        var history = new List<AcademicYearModel>
        {
            new AcademicYearModel
        {
            Year = 2568,  // เพิ่มปี 2568
            Semesters = new List<SemesterModel>
            {

                new SemesterModel {
                    SemesterName = "1",
                    Courses = new ObservableCollection<CourseModel>
                    {
                        new CourseModel { CourseCode = "1204501", CourseName = "Data Science", Schedule = "(L) 30 มี.ค. 2568 | 10:00-12:00", Room = "IT-403" },
                        new CourseModel { CourseCode = "1204502", CourseName = "Blockchain Technology", Schedule = "(L) 1 เม.ย. 2568 | 14:00-16:00", Room = "IT-404" },
                        new CourseModel { CourseCode = "1204503", CourseName = "Cyber Security", Schedule = "(L) 5 เม.ย. 2568 | 09:00-12:00", Room = "IT-405" },
                        new CourseModel { CourseCode = "1204504", CourseName = "Cloud Computing", Schedule = "(L) 6 เม.ย. 2568 | 13:00-16:00", Room = "IT-406" },
                        new CourseModel { CourseCode = "1204505", CourseName = "Web Development", Schedule = "(L) 7 เม.ย. 2568 | 10:00-12:00", Room = "IT-407" },
                    }
                },
                new SemesterModel
                {
                    SemesterName = "2",
                    Courses = new ObservableCollection<CourseModel>
                    {
                        new CourseModel { CourseCode = "1204305", CourseName = "Computer Graphics", Schedule = "(C) 21 มี.ค. 2568 | 13:00-16:00", Room = "ห้องเรียน: IT-412 (10)" },
                        new CourseModel { CourseCode = "1204306", CourseName = "Software Engineering", Schedule = "(C) 19 มี.ค. 2568 | 13:00-16:00", Room = "ห้องเรียน: IT-412 (23)" },
                        new CourseModel { CourseCode = "1204307", CourseName = "Artificial Intelligence", Schedule = "(L) 25 มี.ค. 2568 | 13:00-16:30", Room = "ห้องเรียน: IT-401 (11)" },
                        new CourseModel { CourseCode = "1204407", CourseName = "Machine Learning", Schedule = "(L) 24 มี.ค. 2568 | 08:00-17:00", Room = "ห้องเรียน: IT-402 (8)" },
                    }
                },
                  {
                    new SemesterModel
                    {
                        SemesterName = "3",
                        Courses = new ObservableCollection<CourseModel>
                        {

                        }
                    }
                }
            }
        },
            new AcademicYearModel
            {
                Year = 2567,
                Semesters = new List<SemesterModel>
                {
                    new SemesterModel
                    {
                        SemesterName = "1",
                        Courses = new ObservableCollection<CourseModel>
                        {
                            new CourseModel { CourseCode = "1204506", CourseName = "Internet of Things", Schedule = "(L) 8 เม.ย. 2568 | 14:00-16:00", Room = "IT-408" },
                            new CourseModel { CourseCode = "1204507", CourseName = "Digital Marketing", Schedule = "(L) 9 เม.ย. 2568 | 10:00-12:00", Room = "IT-409" },
                            new CourseModel { CourseCode = "1204508", CourseName = "Game Development", Schedule = "(L) 10 เม.ย. 2568 | 13:00-16:00", Room = "IT-410" },
                            new CourseModel { CourseCode = "1204305", CourseName = "Computer Graphics", Schedule = "21 มี.ค. 2568 | 13:00-16:00", Room = "IT-412" },
                            new CourseModel { CourseCode = "1204306", CourseName = "Software Engineering", Schedule = "19 มี.ค. 2568 | 13:00-16:00", Room = "IT-412" }
                        }
                    },
                    new SemesterModel
                    {
                        SemesterName = "2",
                        Courses = new ObservableCollection<CourseModel>
                        {
                            new CourseModel { CourseCode = "1204407", CourseName = "Machine Learning", Schedule = "24 มี.ค. 2568 | 08:00-17:00", Room = "IT-402" },
                            new CourseModel { CourseCode = "1204509", CourseName = "Mobile App Development", Schedule = "(L) 11 เม.ย. 2568 | 10:00-12:00", Room = "IT-411" },
                            new CourseModel { CourseCode = "1204510", CourseName = "Computer Vision", Schedule = "(L) 12 เม.ย. 2568 | 14:00-16:00", Room = "IT-412" },
                            new CourseModel { CourseCode = "1204434", CourseName = "Software Testing", Schedule = "(L) 27 มี.ค. 2568 | 14:00-17:00", Room = "IT-403" },
                        }
                    },
                 {
                    new SemesterModel
                    {
                        SemesterName = "3",
                        Courses = new ObservableCollection<CourseModel>
                        {
                            new CourseModel { CourseCode = "1204435", CourseName = "Big Data Analytics", Schedule = "(L) 28 มี.ค. 2568 | 13:00-15:00", Room = "IT-404" }
                        }
                    }
                }
                }
            },
            new AcademicYearModel
            {
                Year = 2566,
                Semesters = new List<SemesterModel>
                {
                    new SemesterModel
                    {
                        SemesterName = "1",
                        Courses = new ObservableCollection<CourseModel>
                        {
                            new CourseModel { CourseCode = "1204201", CourseName = "Data Structures", Schedule = "10 มี.ค. 2567 | 10:00-12:00", Room = "IT-101" },
                        }
                    },
                    new SemesterModel
                    {
                        SemesterName = "2",
                        Courses = new ObservableCollection<CourseModel>
                        {
                            new CourseModel { CourseCode = "1204202", CourseName = "Algorithms", Schedule = "15 มี.ค. 2567 | 14:00-16:00", Room = "IT-102" }
                        }
                    },
                         new SemesterModel
                    {
                        SemesterName = "3",
                        Courses = new ObservableCollection<CourseModel>
                        {
                        new CourseModel { CourseCode = "1204433", CourseName = "Cross Platform Mobile App", Schedule = "(L) 26 มี.ค. 2568 | 12:00-17:00", Room = "ห้องเรียน: IT-401 (7)" }
                        }
                    }
                },
            }
        };

        // เรียงลำดับปีจากมากไปน้อย
        var sortedHistory = history.OrderByDescending(y => y.Year).ToList();

        AvailableYears = new ObservableCollection<AcademicYearModel>(sortedHistory);

        // ตั้งค่าให้ปีแรกสุด (ปีล่าสุด) เป็นค่าเริ่มต้น
        if (AvailableYears.Count > 0)
        {
            SelectedYear = AvailableYears.First();
        }
    }

    [RelayCommand]
    private void SelectYear(AcademicYearModel year)
    {
        SelectedYear = year;
        Console.WriteLine($"Selected Year: {year.Year}");
    }
}
