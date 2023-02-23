using RecordStore.Core.Entities;

namespace RecordStore.Core.Repositories
{
    public interface IUserRepository
    {
        Task CreateUserAsync(User user);
        Task<User> GetByIdAsync(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password); 

    }
}
