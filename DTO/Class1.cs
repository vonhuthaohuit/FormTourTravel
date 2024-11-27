using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DTO
{
    public class Class1
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public void test()
        {
            user user = new user();
            db.users.Add(user);
        }
    }
}
