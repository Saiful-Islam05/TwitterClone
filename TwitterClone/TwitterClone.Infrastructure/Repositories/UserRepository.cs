using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;
using TwitterClone.Infrastructure.Persistence;

namespace TwitterClone.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly TwitterCloneDbContext? _context;


        public UserRepository(TwitterCloneDbContext? context)
        {
            _context = context;
        }

      
        public User AddUser(User user)
        {
            //_users.Add(user);
            //return user;


            _context?.Users.Add(user);
            _context?.SaveChanges();

            return user;
        }


        public User UpdateUser(User user)
        {
            //_users.RemoveAll(u => u.Id == user.Id);
            //_users.Add(user);

            _context?.Users.Update(user);
            _context?.SaveChanges();
            return user;
        }

        public bool DeleteUser(User user)
        {
            //return _users.Remove(user);

            _context?.Users.Remove(user);
            _context?.SaveChanges();
            return true;
        }

        public User? GetUserById(Guid id)
        {
            //return _users.SingleOrDefault(u => u.Id == id);

            return _context?.Users.SingleOrDefault(u => u.Id == id);

        }

        public List<User> GetUsers()
        {
            //return _users;
            return _context?.Users.ToList() ?? new List<User>();
        }

        public User? GetUserByEmail(string email)
        {
            //return _users.SingleOrDefault(u => u.Email == email);
            return _context?.Users.SingleOrDefault(u => u.Email == email);
        }
    }
}
