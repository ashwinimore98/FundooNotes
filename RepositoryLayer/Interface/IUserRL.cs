using CommonLayer.Model;
using CommonLayer.Models;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using UserEntity = RepositoryLayer.Entity.UserEntity;

namespace RepositoryLayer.Interfaces
{
    public interface IUserRL
    {
        public UserEntity UserRegistration(UserRegistration user);

        public string LoginUser(LoginUser loginUser);
        public string GenerateJWTToken(long userid, string email);
        public string ForgetPassword(string email);
        public bool ResetPassword(string email, string password, string confirmpassword);
        UserEntity Registration(UserRegistration userRegistration);
    }
}