using Core.Dtos;
using DataLayer.Entities;
using DataLayer.Repositories;

namespace Core.Services
{
    public class UserService
    {
        private UserRepository UserRepository { get; set; }

        public UserService(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public List<User> GetAll()
        {
            var results = UserRepository.GetAll();

            return results;
        }

        public User GetById(int userId)
        {
            var result = UserRepository.GetById(userId);

            return result;
        }

        public bool EditUsername(UserUpdateDto payload)
        {
            var result = UserRepository.GetById(payload.Id);

            result.Username = payload.Username;

            return true;
        }
        
        public void Add(User user)
        {
            UserRepository.Add(user);
        }
        
        public void Delete(int userId)
        {
            UserRepository.Delete(userId);
        }
    }
}
