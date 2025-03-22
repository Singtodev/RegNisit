namespace RegNisit.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		EmailEntry.Text = "admin@admin.com";
		passwordEntry.Text = "1";
		errorLabel.IsVisible = false;
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	{
		string Email = EmailEntry.Text;
		string password = passwordEntry.Text;

		if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(password))
		{
			errorLabel.Text = "Please enter both Email and password.";
			errorLabel.IsVisible = true;
			return;
		}

		if (Email == "admin@admin.com" && password == "1")
		{
			await DisplayAlert("Login Successful", $"Welcome, Singharat Bunphim!", "OK");
			errorLabel.IsVisible = false;
			await Shell.Current.GoToAsync(nameof(HomePage));
		}
		else
		{
			errorLabel.Text = "Invalid Email or password.";
			errorLabel.IsVisible = true;
		}
	}

}