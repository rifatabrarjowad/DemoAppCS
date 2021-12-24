using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlLite.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(250)]
        public string Experience { get; set; }
    }
}
