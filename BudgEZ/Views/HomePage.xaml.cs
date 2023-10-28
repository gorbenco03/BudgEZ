

namespace BudgEZ.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private void OnSearchButtonPressed(object sender, EventArgs e)
    {
        cityInfoLabel.Text = "Please enter the city "; 
        string cityName = citySearchBar.Text;
        string cityInfo = GetCityInfo(cityName); 

        if (!string.IsNullOrEmpty(cityInfo))
        {
            cityInfoLabel.Text = cityInfo;
        }
        else
        {
            cityInfoLabel.Text = "City not found.";
        }
    }
    private string GetCityInfo(string cityName)
    {

       
        var cityInfoDictionary = new Dictionary<string, string>
    {
        { "New York", "0,7 km from you" },
       { "Timisoara", "500m from you\n250m from you" },
        { "Chicago", "right now we don't have disponibility" }
        
    };

        if (cityInfoDictionary.ContainsKey(cityName))
        {
            return cityInfoDictionary[cityName];
        }

        return string.Empty;
    }

    
    private void  Button_Clicked(object sender, EventArgs e)
    {

        string Code = myCode.Text;
        if (Code == "111111")
        {
            DisplayAlert("Inchiriere Reusita", "Aveti grija la drum", "inchide"); 
        }
        else if (Code.Length < 6) {
            DisplayAlert("Eroare" , "Ai introdus un cod invalid", "ok");

        }
        else if (string.IsNullOrEmpty(Code)) {
            DisplayAlert("Eroare", "nu ai introdus nici un cod", "ok"); 
        }

    }
    private void OnLabelTapped(object sender, EventArgs e)
    {
      
        DisplayAlert("Confirmare", "Daca doresti sa alegi aceasta trotineta apasa ok, in acest caz vei primi un mesaj pe telefon cu codul de confimare", "OK");
    }
}