using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace SampleWeb.Entities
{
    [Table(Name = "User")]
    public class User
    {

        [Column(Name = "ID", IsPrimaryKey=true)]
        public string ID { get; set; }

        [Column(Name = "Account")]
        public string Account { get; set; }

        [Column(Name = "Password")]
        public string Password { get; set; }

        [Column(Name = "Email")]
        public string Email { get; set; }


        #region Methods

        public static User Get(DataContext context, string account)
        {
            var users = context.GetTable<User>();
            var query = from user in users
                        where user.Account == account
                        select user;

            foreach (var it in query)
            {
                return it;
            }

            return null;
        }

        public static User Get(DataContext context, string account, string password)
        {
            var users = context.GetTable<User>();
            var query = from user in users
                        where user.Account == account && user.Password == password
                        select user;

            foreach (var it in query)
            {
                return it;
            }

            return null;
        }

        public static void Add(DataContext context, string account, string password, string email = "")
        {
            var users = context.GetTable<User>();
            var user = new User() { Account = account, Password = password, Email = email, ID= Guid.NewGuid().ToString() };
            users.InsertOnSubmit(user);
        }

        #endregion
    }

}