using DataLayer.Entities;

namespace DataLayer.Repositories
{
    public class UserRepository
    {
        public List<User> GetAll()
        {
            var results = DbContext.Users;

            return results;
        }

        public User GetById(int userId)
        {
            var result = DbContext.Users.Where(x => x.Id == userId).FirstOrDefault();

            return result;
        }
    }
}
