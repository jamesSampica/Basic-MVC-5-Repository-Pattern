using BasicRepositoryPattern.Business.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRepositoryPattern.Business.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private UserRepository _userRepository;
        public UserRepository UserRepository
        {
            get 
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(Context);
                }

                return _userRepository;
            }
            private set
            {
                if (_userRepository != value) _userRepository = value;
            }
        }

        private RoleRepository _roleRepository;
        public RoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new RoleRepository(Context);
                }

                return _roleRepository;
            }
            private set
            {
                if (_roleRepository != value) _roleRepository = value;
            }
        }

        private MyModelContainer Context;

        public UnitOfWork(MyModelContainer context)
        {
            Context = context;
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
