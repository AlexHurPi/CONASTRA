﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin6.Model
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string age { get; set; }
        public DateTime Creation_Date{ get; set; }




    }
}
