﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp2.Model
{
    class Order
    {
        [PrimaryKey, AutoIncrement]
        int ID { get; set; }

        string Address { get; set; }

        public int Cena
        {
            get => default(int);
            set
            {
            }
        }
    }
}
