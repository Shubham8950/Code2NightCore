using System;
using System.Collections.Generic;
using Code2Night.DAL.Common;

namespace Code2Night.DAL.Interfaces
{
    public interface IUserRepo
    {
        List<Users> GetUsers ();
        int AddNewAccount(Users user);
        long ActivateAccount(Guid ActivationCode);
        List<string> GetExistingUserNames();
        Users UserLogin(string UserName, string Password);
        bool ResendVerificationMail(string Email);
        void UserDelete(int userid);
        Users GetUserByUserId(int userId);
    }
}
