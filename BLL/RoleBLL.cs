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

        public List<quyen> layQuyen()
        {
            return roleBll.layQuyen();
        }

        public bool ThemNhomQuyen(nhomquyen role)
        {
            return roleBll.ThemNhomQuyen(role);
        }

        public bool XoaNhomQuyen(int manhomquyen)
        {
            return roleBll.XoaNhomQuyen(manhomquyen);
        }

        public bool SuaNhomQuyen(nhomquyen role)
        {
            return roleBll.SuaNhomQuyen(role);
        }

        public bool ThemQuyen(quyen permission)
        {
            return roleBll.ThemQuyen(permission);
        }

        public bool XoaQuyen(int maquyen)
        {
            return roleBll.XoaQuyen(maquyen);
        }

        public bool SuaQuyen(quyen permission)
        {
            return roleBll.SuaQuyen(permission);
        }
    }
}