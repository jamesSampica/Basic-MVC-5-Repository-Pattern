using BasicRepositoryPattern.Business.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRepositoryPattern.Business.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(MyModelContainer context) : base(context) { }

        public IEnumerable<AspNetUser> GetActiveUsers()
        {
            return Context.AspNetUsers;
        }

        public int GetUserCount()
        {
            return Context.AspNetUsers.Count();
        }
    }
}
