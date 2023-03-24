using Core.Dtos;
using DataLayer.Entities;
using DataLayer.Repositories;

namespace Core.Services
{
    public class UserService
    {
        public UserRepository UserRepository { get; set; }

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
            if (payload == null || payload.Username == null)
            {
                return false;
            }

            var result = UserRepository.GetById(payload.Id);

            if (result == null)
            {
                return false;
            }

            result.Username = payload.Username;

            return true;
        }
    }
}
