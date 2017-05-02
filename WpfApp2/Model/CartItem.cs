using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace WpfApp2.Model
{
    public class CartItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int CartID { get; set; }

        public int ItemID { get; set; }
    }
}