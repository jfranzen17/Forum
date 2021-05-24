using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using Dapper;
using System.Linq;

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

    class UserRepository
    {
        private const string _connectionString = "Data Source=./Forum.db";

        public List<User> GetUsers()
        {
            using var connection = new SqliteConnection(_connectionString);
            var output = connection.Query<User>("SELECT * FROM users");
            return output.ToList();
        }

        public User GetUserWhoCreatedThread(int id)
        {
            using var connection = new SqliteConnection(_connectionString);
            var query = "SELECT * FROM Users WHERE UserId =@UserId";
            return connection.QuerySingle<User>(query, new { UserId = id });
        }
    }
}
