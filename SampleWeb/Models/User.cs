using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace SampleWeb.Models
{
    [Table(Name = "User")]
    public class User : BaseModel
    {
        [Column(Name = "Account")]
        public string Account { get; set; }

        [Column(Name = "Password")]
        public string Password { get; set; }

        [Column(Name = "Email")]
        public string Email { get; set; }


        #region Methods

        public static User GetUser(DataContext context, string account)
        {
            return context.GetTable<User>().First(item => item.Account == account);
        }

        public static User GetUser(DataContext context, string account, string password)
        {
            return context.GetTable<User>().First(item => item.Account == account && item.Password == password);
        }

        #endregion
    }

}