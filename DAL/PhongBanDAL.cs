using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class PhongBanDAL
    {
        private ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();

        public List<department> LayDanhSachPhongBan()
        {
            return db.departments.ToList();
        }
    }
}
