using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuminoDashBoard.Models.ViewModel
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        
        public string Password { get; set; }
        public string Usertype { get; set; }
        public string Fullname { get; set; }

    }
}