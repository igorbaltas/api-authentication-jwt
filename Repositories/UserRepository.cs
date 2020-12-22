using System.Collections.Generic;
using System.Linq;
using APIAuthenticationJWT.Models;

namespace APIAuthenticationJWT.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password){
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "joel", Password = "joel", Role = "manager" });
            users.Add(new User { Id = 1, Username = "price", Password = "price", Role = "employee" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }

    }
}