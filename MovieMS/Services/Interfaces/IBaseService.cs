using System;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IBaseService<T>
    {
        
        Task<int> Add(T obj);
        Task Update(T obj);
        Task Delete(int id);
    }
}