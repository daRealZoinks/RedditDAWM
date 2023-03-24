using DataLayer.Entities;

namespace DataLayer
{
    public class DbContext
    {
        public static List<User> Users { get; set; } = new()
        {
            new User { Id = 1, Username = "David", Email = "david@gmail.com", Password = "1234", Description = "I am a developer" },
            new User { Id = 2, Username = "John", Email = "john@gmail.com",  Password = "1234",  Description = "I am a chef" },
            new User { Id = 3, Username = "Mary", Email = "mary@gmail.com",  Password = "1234", Description = "I am a teacher" },
            new User { Id = 4, Username = "Peter", Email = "peter@gmail.com",  Password = "1234", Description = "I am a doctor" },
            new User { Id = 5, Username = "Jane", Email = "jane@gmail.com",  Password = "1234", Description = "I am a clown" },
            new User { Id = 6, Username = "Sara", Email = "sara@gmail.com",  Password = "1234", Description = "I am a lawyer" },
            new User { Id = 7, Username = "Paul", Email = "paul@gmail.com",  Password = "1234", Description = "I am a pilot" },
            new User { Id = 8, Username = "Mark", Email = "mark@gmail.com",  Password = "1234", Description = "I am a farmer" },
            new User { Id = 9, Username = "Sandra", Email = "sandra@gmail.com",  Password = "1234", Description = "I am a nurse" },
            new User { Id = 10, Username = "Laura", Email = "laura@gmail.com",  Password = "1234", Description = "I am a student" }
        };
    }
}
