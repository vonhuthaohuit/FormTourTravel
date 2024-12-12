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

        public List<quyen> layQuyen()
        {
            List<quyen> permissions = new List<quyen>();
            permissions = db.quyens.ToList();
            return permissions;
        }

        public bool ThemNhomQuyen(nhomquyen role)
        {
            db.nhomquyens.Add(role);
            return db.SaveChanges() > 0;
        }

        public bool XoaNhomQuyen(int manhomquyen)
        {
            nhomquyen role = db.nhomquyens.Find(manhomquyen);
            db.nhomquyens.Remove(role);
            return db.SaveChanges() > 0;
        }

        public bool SuaNhomQuyen(nhomquyen role)
        {
            nhomquyen roleUpdate = db.nhomquyens.Find(role.manhomquyen);
            roleUpdate.tennhomquyen = role.tennhomquyen;
            return db.SaveChanges() > 0;
        }

        public bool ThemQuyen(quyen permission)
        {
            db.quyens.Add(permission);
            return db.SaveChanges() > 0;
        }

        public bool XoaQuyen(int maquyen)
        {
            quyen permission = db.quyens.Find(maquyen);
            db.quyens.Remove(permission);
            return db.SaveChanges() > 0;
        }

        public bool SuaQuyen(quyen permission)
        {
            quyen permissionUpdate = db.quyens.Find(permission.maquyen);
            permissionUpdate.tenquyen = permission.tenquyen;
            return db.SaveChanges() > 0;
        }
    }
}
