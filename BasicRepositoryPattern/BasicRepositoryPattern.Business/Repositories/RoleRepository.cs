using BasicRepositoryPattern.Business.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRepositoryPattern.Business.Repositories
{
    public class RoleRepository : BaseRepository
    {
        public RoleRepository(MyModelContainer context) : base(context) { }

        public int GetRoleCount()
        {
            return Context.AspNetRoles.Count();
        }
    }
}
