using System.Collections.ObjectModel;

namespace RegNisit.Pages;

public partial class UserProfilePage : ContentPage
{
    public UserProfilePage()
    {
        InitializeComponent();
        BindingContext = new UserProfileViewModel();
    }

    private async void OnAvatarTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Change Avatar", "Avatar tapped!", "OK");
        // เพิ่มโค้ดเลือกไฟล์หรืออัปเดตรูปภาพ
    }
}

public class UserProfileViewModel
{
    public string Email { get; set; } = "user@example.com";
    public string BirthDate { get; set; } = "2000-01-01";
    public int AdmissionYear { get; set; } = 2020;
    public int CurrentYear { get; set; } = 4;
    public ObservableCollection<Course> RegisteredCourses { get; set; }
    public double GPAX { get; set; } = 3.75;

    public UserProfileViewModel()
    {
        RegisteredCourses = new ObservableCollection<Course>
        {
            new Course { CourseName = "Mathematics 101" },
            new Course { CourseName = "Physics 201" },
            new Course { CourseName = "Computer Science 305" }
        };
    }
}

public class Course
{
    public string CourseName { get; set; }
}
