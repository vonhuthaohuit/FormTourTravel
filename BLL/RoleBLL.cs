using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class RoleBLL
    {
        private RoleDAL roleBll = new RoleDAL();
        public List<nhomquyen> LayNhomQuyen()
        {
            return roleBll.LayNhomQuyen();
        }
    }
}