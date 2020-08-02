using uppu_api.Entities;

namespace uppu_api.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }
}
