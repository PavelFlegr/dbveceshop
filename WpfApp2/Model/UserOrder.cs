using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp2.Model
{
    class UserOrder
    {
        [PrimaryKey, AutoIncrement]
        int ID { get; set; }

        int UserID { get; set; }
        int OrderID { get; set; }
    }
}
