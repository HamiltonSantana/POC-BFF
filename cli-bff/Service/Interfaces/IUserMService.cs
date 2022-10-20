using System;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUserMService
    {
       Task GetUser(int id);
    }
}