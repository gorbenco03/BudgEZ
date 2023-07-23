using BudgEZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgEZ.Service
{
    public class LoginRepository : ILoginRepository
    {
        public Task<UserInfo> Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
