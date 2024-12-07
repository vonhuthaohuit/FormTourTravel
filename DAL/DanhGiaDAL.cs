using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DanhGiaDAL
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public List<danhgia> LayDanhSachDanhGia()
        {
            return db.danhgias.ToList();
        }
    }
}
