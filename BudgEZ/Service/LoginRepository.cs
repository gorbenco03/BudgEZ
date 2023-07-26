using BudgEZ.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgEZ.Service
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<UserInfo> Login(string username, string password)
        {

            var userInfo = new List<UserInfo>();
            var client = new HttpClient();

            string url = "http://192.168.1.184:8082/api/userinfoes/LoginUser/" + username + "/" + password;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage responseMessage = await client.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                string content = responseMessage.Content.ReadAsStringAsync().Result;
                userInfo = JsonConvert.DeserializeObject<List<UserInfo>>(content);
                return await Task.FromResult(userInfo.FirstOrDefault());
            }

            else
            {
                return null;
            }
        }
    }
}
