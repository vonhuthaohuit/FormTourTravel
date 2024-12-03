using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;
using System.Linq;

namespace DAL
{
    public class UsersDAL
    {
        private readonly ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();

        public long layMaTaiKhoan(string userName, string passWord)
        {
            var user = db.users
                .Where(t => t.tentaikhoan.Equals(userName))
                .FirstOrDefault();

            if (user == null)
                return -1;

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(passWord, user.matkhau);

            if (isPasswordValid)
                return user.mataikhoan;
            else
                return -1;
        }

        public bool kiemTraDangNhap(string userName, string passWord)
        {
            var user = db.users
                .Where(t => t.tentaikhoan == userName)
                .FirstOrDefault();

            if (user != null && BCrypt.Net.BCrypt.Verify(passWord, user.matkhau))
            {
                return true;
            }

            return false; 
        }

        public long kiemTraNhomQuyen(long maTaiKhoan)
        {
            var nhomQuyen = db.nhomquyens
                .Where(nq => nq.users.Any(u => u.mataikhoan == maTaiKhoan))
                .Select(nq => nq.manhomquyen)
                .FirstOrDefault();

            return nhomQuyen;
        }

        public List<user> LayTatCaUser()
        {
            List<user> users = db.users.ToList();
            return users;
        }
    }
}
