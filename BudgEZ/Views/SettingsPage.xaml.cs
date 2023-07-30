namespace BudgEZ.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (Preferences.ContainsKey(nameof(App.UserInfo)))
        {
            Preferences.Remove(nameof(App.UserInfo));
        }
         Shell.Current.GoToAsync($"//{nameof(LoginPage)}");

    }
}