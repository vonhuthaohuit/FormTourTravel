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
        public List<nhomquyen> LayNhomQuyen()
        {
            List<nhomquyen> roles = new List<nhomquyen>();
            roles = db.nhomquyens.ToList();
            return roles;
        }
    }
}
