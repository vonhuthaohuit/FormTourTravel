using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class UsersBLL
    {
        UsersDAL usersDAL = new UsersDAL();
        public long layMaTaiKhoan(string userName, string passWord)
        {
            return usersDAL.layMaTaiKhoan(userName, passWord);
        }
        public long kiemTraNhomQuyen(long maTaiKhoan)
        {
            return usersDAL.kiemTraNhomQuyen(maTaiKhoan);
        }
        public bool kiemTraDangNhap(string userName, string passWord)
        {
            return usersDAL.kiemTraDangNhap(userName, passWord);
        }

        public List<user> LayTatCaUser()
        {
            return usersDAL.LayTatCaUser();
        }
        public user TaoTaiKhoanNguoiDaiDien(string tenTaiKhoan,string email)
        {
            try
            {
                return usersDAL.TaoTaiKhoanNguoiDaiDien(tenTaiKhoan, email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
