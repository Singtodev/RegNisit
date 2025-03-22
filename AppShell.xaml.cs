using RegNisit.Pages;

namespace RegNisit;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		// Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(UserProfilePage), typeof(UserProfilePage));
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		Routing.RegisterRoute(nameof(CourseHistoryPage), typeof(CourseHistoryPage));
		Routing.RegisterRoute(nameof(EnrollCoursePage), typeof(EnrollCoursePage));
	}
}
