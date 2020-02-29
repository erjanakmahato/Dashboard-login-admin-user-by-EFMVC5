using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuminoDashBoard.Models.ViewModel
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}