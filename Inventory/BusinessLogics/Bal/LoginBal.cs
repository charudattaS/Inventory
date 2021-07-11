using DalAccess.IDal;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogics.Bal
{
  public class LoginBal
    {
        private ILogin dal;
        public LoginBal(ILogin dal)
        {
            this.dal = dal;
        }

        public ApplicationUser Login(ApplicationUser applicationUser) 
        {
            applicationUser.IsUsed = true;
            applicationUser= dal.Login(applicationUser);
            return applicationUser;
        }
    }
}
