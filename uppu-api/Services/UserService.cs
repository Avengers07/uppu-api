using uppu_api.Entities;

namespace uppu_api.Services
{
    public class UserService : IUserService
    {
        
        public UserService()
        {

        }

        public User Authenticate(string username, string password)
        {
            
            // logic to validate user
            return new User();

        }
    }
}
