using BudgEZ.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BudgEZ.Service
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<UserInfo> Login(string username, string password)
        {
            try
            {

                if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userInfo = new List<UserInfo>();
                    var client = new HttpClient();
                    string url = "http://172.27.240.1:8082/api/userinfoes/LoginUser/" + username + "/" + password;
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage response = await client.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {
                        string content = response.Content.ReadAsStringAsync().Result;
                        userInfo = JsonConvert.DeserializeObject<List<UserInfo>>(content);
                        //   userInfo = await response.Content.ReadFromJsonAsync<UserInfo>();
                        return await Task.FromResult(userInfo.FirstOrDefault());
                    }

                    else
                    {
                        return null;
                    }
                    }

                    else
                    {

                        return null;
                    }




                }
            catch (Exception)
            {

                await Application.Current.MainPage.DisplayAlert("Eroare", "A apărut o eroare în timpul autentificării.", "OK");

                return null;
            }

        }
           
    }
}
