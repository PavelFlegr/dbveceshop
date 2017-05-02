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
        public int ID { get; set; }
        public int Price { get; set; }
        string Name { get; set; }
        Dictionary<string, string> Specification { get; set; }

        public int CategoryID
        {
            get => default(int);
            set
            {
            }
        }
    }
}
