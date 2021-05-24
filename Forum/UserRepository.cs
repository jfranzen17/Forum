using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace Forum
{
    public class User
    {
        private int _id = -1;

        public int Id
        {
            get { return _id; }
            set { if (_id == -1) _id = value; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


    }
}
