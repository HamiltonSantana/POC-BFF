using System.Threading.Tasks;
using Domain.Entities;

namespace Services.Interfaces
{
    public interface IUserServices
    {
        Task<User> GetUser(int id);
        Task UpdateUser(User user);
    }
}