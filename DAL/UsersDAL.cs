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

        public bool ThemUser(user user)
        {
            db.users.Add(user);
            return db.SaveChanges() > 0;
        }

        public bool SuaUser(user us)
        {
            user us1 = db.users.Find(us.mataikhoan);
            us1.tentaikhoan = us.tentaikhoan;
            us1.email = us.email;
            us1.matkhau = us.matkhau;
            us1.trangthai = us.trangthai;
            us1.manhomquyen = us.manhomquyen;
            return db.SaveChanges() > 0;
        }

        public bool XoaUser(int mataikhoan)
        {
            user us = db.users.Find(mataikhoan);
            db.users.Remove(us);
            return db.SaveChanges() > 0;
        }
        public user TaoTaiKhoanNguoiDaiDien(string userName, string email)
        {
            try
            {
                var user = new user
                {
                    tentaikhoan = userName,
                    email = email,
                    matkhau = BCrypt.Net.BCrypt.HashPassword("123456"),
                    manhomquyen = 2
                };
                db.users.Add(user);
                db.SaveChanges();
                return user;
            }
            catch
            {
                return null;

            }
        }
    }
}
