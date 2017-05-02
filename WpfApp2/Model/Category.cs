﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp2.Model
{
    class Category
    {
        [PrimaryKey, AutoIncrement]
        int ID { get; set; }
        string Name { get; set; }
        List<string> Specification { get; set; }
    }
}
