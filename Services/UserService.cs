using AdminUserManagement.Models;
using AdminUserManagement.Services.Interface;
using System.Net.Http.Json;

namespace AdminUserManagement.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var result = await _http.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users") ?? new List<User>();
            return result;
        }
    }
}
