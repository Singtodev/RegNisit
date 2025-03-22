using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RegNisit.Models;

namespace RegNisit.ViewModels;

public partial class EnrollCourseViewModel : ObservableObject
{
	[ObservableProperty]
	private ObservableCollection<CourseModel> enrolledCourses = new(); // วิชาที่ลงทะเบียนแล้ว

	[ObservableProperty]
	private ObservableCollection<CourseModel> availableCourses = new(); // วิชาที่ยังไม่ลงทะเบียน

	[ObservableProperty]
	private ObservableCollection<CourseModel> filteredCourses = new(); // รายการที่ใช้แสดงผลหลังการค้นหา

	[ObservableProperty]
	private string searchText;

	public EnrollCourseViewModel()
	{
		LoadCourses();
	}
	private void LoadCourses()
	{
		// วิชาที่ยังไม่ลงทะเบียน
		AvailableCourses = new ObservableCollection<CourseModel>
	{   new CourseModel { CourseCode = "1204202", CourseName = "Algorithms", Schedule = "15 มี.ค. 2567 | 14:00-16:00", Room = "IT-102" },
		new CourseModel { CourseCode = "1204201", CourseName = "Data Structures", Schedule = "10 มี.ค. 2567 | 10:00-12:00", Room = "IT-101" },
		new CourseModel { CourseCode = "1204506", CourseName = "Internet of Things", Schedule = "(L) 8 เม.ย. 2568 | 14:00-16:00", Room = "IT-408" },
		new CourseModel { CourseCode = "1204507", CourseName = "Digital Marketing", Schedule = "(L) 9 เม.ย. 2568 | 10:00-12:00", Room = "IT-409" },
		new CourseModel { CourseCode = "1204508", CourseName = "Game Development", Schedule = "(L) 10 เม.ย. 2568 | 13:00-16:00", Room = "IT-410" },
		new CourseModel { CourseCode = "1204305", CourseName = "Computer Graphics", Schedule = "21 มี.ค. 2568 | 13:00-16:00", Room = "IT-412" },
		new CourseModel { CourseCode = "1204306", CourseName = "Software Engineering", Schedule = "19 มี.ค. 2568 | 13:00-16:00", Room = "IT-412" },
		new CourseModel { CourseCode = "1204407", CourseName = "Machine Learning", Schedule = "24 มี.ค. 2568 | 08:00-17:00", Room = "IT-402" },
		new CourseModel { CourseCode = "1204509", CourseName = "Mobile App Development", Schedule = "(L) 11 เม.ย. 2568 | 10:00-12:00", Room = "IT-411" },
		new CourseModel { CourseCode = "1204510", CourseName = "Computer Vision", Schedule = "(L) 12 เม.ย. 2568 | 14:00-16:00", Room = "IT-412" },
		new CourseModel { CourseCode = "1204434", CourseName = "Software Testing", Schedule = "(L) 27 มี.ค. 2568 | 14:00-17:00", Room = "IT-403" },
		new CourseModel { CourseCode = "1204435", CourseName = "Big Data Analytics", Schedule = "(L) 28 มี.ค. 2568 | 13:00-15:00", Room = "IT-404" }
	};

		// วิชาที่ลงทะเบียนแล้ว
		EnrolledCourses = new ObservableCollection<CourseModel>
	{
		new CourseModel { CourseCode = "1204305", CourseName = "Computer Graphics", Schedule = "(C) 21 มี.ค. 2568 | 13:00-16:00", Room = "ห้องเรียน: IT-412 (10)" },
		new CourseModel { CourseCode = "1204306", CourseName = "Software Engineering", Schedule = "(C) 19 มี.ค. 2568 | 13:00-16:00", Room = "ห้องเรียน: IT-412 (23)" },
		new CourseModel { CourseCode = "1204307", CourseName = "Artificial Intelligence", Schedule = "(L) 25 มี.ค. 2568 | 13:00-16:30", Room = "ห้องเรียน: IT-401 (11)" },
		new CourseModel { CourseCode = "1204407", CourseName = "Machine Learning", Schedule = "(L) 24 มี.ค. 2568 | 08:00-17:00", Room = "ห้องเรียน: IT-402 (8)" },
		new CourseModel { CourseCode = "1204433", CourseName = "Cross Platform Mobile App", Schedule = "(L) 26 มี.ค. 2568 | 12:00-17:00", Room = "ห้องเรียน: IT-401 (7)" }
	};

		// อัปเดตรายการวิชาที่ใช้แสดงผลหลังค้นหา
		FilteredCourses = new ObservableCollection<CourseModel>(AvailableCourses);
	}


	[RelayCommand]
	private void PerformSearch()
	{
		if (string.IsNullOrWhiteSpace(SearchText))
		{
			FilteredCourses = new ObservableCollection<CourseModel>(AvailableCourses);
		}
		else
		{
			var filtered = AvailableCourses
				.Where(c => c.CourseName.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
							c.CourseCode.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
				.ToList();

			FilteredCourses.Clear();
			foreach (var course in filtered)
			{
				FilteredCourses.Add(course);
			}
		}

		OnPropertyChanged(nameof(FilteredCourses));
	}

	[RelayCommand]
	private void EnrollCourse(CourseModel course)
	{
		if (AvailableCourses.Contains(course))
		{
			AvailableCourses.Remove(course);
			EnrolledCourses.Add(course);
			PerformSearch();
		}
	}

	[RelayCommand]
	private void UnenrollCourse(CourseModel course)
	{
		if (EnrolledCourses.Contains(course))
		{
			EnrolledCourses.Remove(course);
			AvailableCourses.Add(course);
			PerformSearch();
		}
	}

	[RelayCommand]
	private async void SaveCommand()
	{
		await Application.Current.MainPage.DisplayAlert(
			"บันทึกการลงทะเบียน",
			"คุณต้องการบันทึกการลงทะเบียนเรียนหรือไม่?",
			"ตกลง");
	}
}
