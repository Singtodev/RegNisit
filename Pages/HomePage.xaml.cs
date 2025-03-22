namespace RegNisit.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	private async void OnLogoutClicked(object sender, EventArgs e)
	{
		bool confirm = await DisplayAlert("Logout", "Are you sure you want to logout?", "Yes", "No");
		if (confirm)
		{
			await Shell.Current.Navigation.PopToRootAsync();
		}
	}

	private async void OnAvatarTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(UserProfilePage));
	}

	private async void OnPlusOrRemoveEnrollClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(EnrollCoursePage));
	}

	private async void OnCourseHistoryClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(CourseHistoryPage));
	}
}