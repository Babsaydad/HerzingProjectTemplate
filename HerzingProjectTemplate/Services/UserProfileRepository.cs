using HerzingProjectTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace HerzingProjectTemplate.Services
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public UserProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public UserProfileInfo GetProfileForUser(int userId)
        {
            return _context.UserProfileInfos
                .FirstOrDefault(p => p.UserId == userId);
        }

        public void SaveProfile(UserProfileInfo profile)
        {
            var existing = _context.UserProfileInfos
                .FirstOrDefault(p => p.UserId == profile.UserId);

            if (existing == null)
            {
                _context.UserProfileInfos.Add(profile);
            }
            else
            {
                existing.Age = profile.Age;
                existing.Height = profile.Height;
                existing.Weight = profile.Weight;
                existing.Gender = profile.Gender;
                existing.ActivityLevel = profile.ActivityLevel;
            }

            _context.SaveChanges();
        }
    }
}
