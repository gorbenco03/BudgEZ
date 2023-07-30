using BudgEZ.Views;

namespace BudgEZ;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage)); 
	}
}
