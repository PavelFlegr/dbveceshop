using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using GenericDB;

namespace WpfApp2.Model
{
    class Cart
    {
        [PrimaryKey, AutoIncrement]
        int ID { get; set; }

        public int CalculatePrice()
        {
            SQLiteConnection c = new SQLiteConnection("TEST");
            return c.Table<CartItem>().Where(ci => ci.CartID == ID).Join(c.Table<Item>(), ci => ci.ItemID, i => i.ID, (ci, i) => i.Price).Sum();
        }
    }
}
