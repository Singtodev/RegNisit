namespace RegNisit.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	{
		string username = usernameEntry.Text;
		string password = passwordEntry.Text;

		if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
		{
			errorLabel.Text = "Please enter both username and password.";
			errorLabel.IsVisible = true;
			return;
		}

		if (username == "admin" && password == "1")
		{
			await DisplayAlert("Login Successful", $"Welcome, Singharat Bunphim!", "OK");
			errorLabel.IsVisible = false;
			await Shell.Current.GoToAsync(nameof(HomePage));
		}
		else
		{
			errorLabel.Text = "Invalid username or password.";
			errorLabel.IsVisible = true;
		}
	}

}