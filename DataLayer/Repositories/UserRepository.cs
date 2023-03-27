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
            var result = DbContext.Users.FirstOrDefault(x => x.Id == userId);

            return result;
        }
        
        public static void Add(User user)
        {
            DbContext.Users.Add(user);
        }
        
        public void Delete(int userId)
        {
            var user = GetById(userId);
            DbContext.Users.Remove(user);
        }
    }
}
