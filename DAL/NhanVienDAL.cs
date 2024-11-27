using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        private ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();

        public List<staff> LayDanhSachNhanVien()
        {
            return db.staffs.ToList();
        }
    }
}
