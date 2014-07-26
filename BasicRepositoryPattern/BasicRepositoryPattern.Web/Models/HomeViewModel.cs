using BasicRepositoryPattern.Business.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicRepositoryPattern.Web.Models
{
    public class HomeViewModel
    {
        public int UserCount { get; set; }
        public int RoleCount { get; set; }
        public IEnumerable<AspNetUser> ActiveUsers { get; set; }
    }
}