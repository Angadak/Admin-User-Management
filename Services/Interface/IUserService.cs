using AdminUserManagement.Models;

namespace AdminUserManagement.Services.Interface
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
    }
}
