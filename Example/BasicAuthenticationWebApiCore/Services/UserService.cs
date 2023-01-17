
using BasicAuthenticationWebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace BasicAuthenticationWebApiCore.Services
{
    public class UserService : IUserService
    {
        private UserContext _context;
        private object context;

        public UserService(UserContext context)
        {
            _context = context;
        }
        public bool ValidateCredentials(string username, string password)
        {
            var uname = from s in _context.Users
                        where s.UserName== username && s.Password== password
                        select s;
            if(uname.Any()) 
            {
                return true;
            }
            return false;

           /* try
            {
                var user = _context.Users.Find(username);//Convert.ToString(username));
                string username1 = user.UserName; 
                string password1 = user.Password;
                return username.Equals(username1) && password.Equals(password1);
            }
            catch(Exception ex)
            {
                return false;
            }  */          
        }
        /*public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin@12");
        }*/
    }
}
