using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infraestructure.DataAccess;
using Services.Interfaces;

namespace Services
{
    public class UserServices : IUserServices
    {
        private DataContext dataContext;

        public UserServices(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<User> GetUser(int id)
        {
           using(dataContext) 
           {
                return await dataContext.User.FindAsync(id);
           }
        }

        public async Task UpdateUser(User user)
        {
            using(dataContext)
            {
                if(!dataContext.User.Any(e => e.Id == user.Id))
                    throw new InvalidOperationException();

                var currentUser = await dataContext.User.FindAsync(user.Id);

                currentUser.Name = user.Name;
                currentUser.Mail = user.Mail;

                await dataContext.SaveChangesAsync();
            }
        }
    }
}