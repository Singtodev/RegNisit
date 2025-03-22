using RegNisit.ViewModels;

namespace RegNisit.Pages;

public partial class EnrollCoursePage : ContentPage
{
	public EnrollCoursePage()
	{
		InitializeComponent();
		BindingContext = new EnrollCourseViewModel();
	}
}