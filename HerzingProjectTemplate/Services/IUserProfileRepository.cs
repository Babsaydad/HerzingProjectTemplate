using HerzingProjectTemplate.Models;

namespace HerzingProjectTemplate.Services
{
    public interface IUserProfileRepository
    {
        public interface IUserProfileRepository
        {
            UserProfileInfo GetProfileForUser(string userId);
            void SaveProfile(UserProfileInfo profile);
        }
    }
}
