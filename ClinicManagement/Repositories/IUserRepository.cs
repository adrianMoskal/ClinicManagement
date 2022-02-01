using ClinicManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Repositories
{
    public interface IUserRepository
    {
        User Get(string userId);
        IEnumerable<User> GetAll();
    }
}
