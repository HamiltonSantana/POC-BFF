using System;
using System.Threading.Tasks;
using Service.Interfaces;

namespace Service
{
    public class UserMService : IUserMService
    {
        public Task GetUser(int id)
        {
            return Task.CompletedTask;
        }
    }
}