using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp2.Model
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        int ID { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Password { get; set; }
        List<Order> Orders { get; set; }
    }
}
