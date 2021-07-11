using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
       public class ApplicationUser : CommonProperties
    {
       
        public String UserName { get; set; }
        public String Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
