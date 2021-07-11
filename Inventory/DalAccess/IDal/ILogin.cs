using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DalAccess.IDal
{
    public interface ILogin
    {
        ApplicationUser Login(ApplicationUser applicationUser);
    }
}
