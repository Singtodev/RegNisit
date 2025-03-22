using RegNisit.ViewModels;

namespace RegNisit.Pages;

public partial class CourseHistoryPage : ContentPage
{
	public CourseHistoryPage()
	{
		InitializeComponent();
		BindingContext = new CourseHistoryViewModel();
	}
}