using ClinicManagement.Data;
using ClinicManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User Get(string userId)
        {
            return _context.Users.SingleOrDefault(x => x.Id == userId);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
    }
}
