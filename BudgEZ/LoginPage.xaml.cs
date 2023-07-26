using BudgEZ.Models;
using BudgEZ.Service;

namespace BudgEZ;

public partial class LoginPage : ContentPage
{
	readonly ILoginRepository _loginRepository = new LoginRepository(); 


	public LoginPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		{
			string userName = myUserName.Text;
			string password = myPassword.Text;
			if (userName == null || password == null)
			{
				DisplayAlert("Warning", "Please input username or password ", "Ok");
				return;
			}
            UserInfo userInfo = await _loginRepository.Login(userName, password);
			if (userInfo != null)
			{
				await Navigation.PushAsync(new MainPage());
			}
			else
			{
				DisplayAlert("Warning", "Username or password incorect ", "OK"); 
			}


		}
	}
}