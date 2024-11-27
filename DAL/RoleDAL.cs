using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class RoleDAL
    {
        private ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public List<role> LayNhomQuyen()
        {
            List<role> roles = new List<role>();
            roles = db.roles.ToList();
            return roles;
        }
    }
}
