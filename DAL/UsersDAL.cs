using System;
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
                .Where(t => t.username.Equals(userName) && t.password.Equals(passWord))
                .Select(t => t.id) 
                .FirstOrDefault();
            if (user == null)
                return -1;
            return user; 
        }
        public long kiemTraNhomQuyen(long maTaiKhoan)
        {
            var nhomQuyen = db.roles
                .Where(nq => nq.users.Any(u => u.id == maTaiKhoan))
                .Select(nq => nq.id)
                .FirstOrDefault();

            return nhomQuyen;
        }

        public bool kiemTraDangNhap(string userName, string passWord)
        {
            var user = db.users
                .Where(t => t.username == userName && t.password == passWord)
                .FirstOrDefault();

            return user != null; 
        }

        public List<user> LayTatCaUser()
        {
            List<user> users = new List<user>();
            users = db.users.ToList();
            return users;
        }



    }
}
