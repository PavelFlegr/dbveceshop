using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp2.Model
{
    abstract class Specification
    {
        [PrimaryKey, AutoIncrement]
        int ID { get; set; }
        Category Category { get; set; }
    }
}
