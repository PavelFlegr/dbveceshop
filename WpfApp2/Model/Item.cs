using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp2.Model
{
    class Item
    {
        [PrimaryKey, AutoIncrement]
        int ID { get; set; }
        int Price { get; set; }
        string Name { get; set; }

        Specification Specification { get; set; }
    }
}
