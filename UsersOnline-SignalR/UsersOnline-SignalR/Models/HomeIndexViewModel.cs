using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersOnline_SignalR.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}