using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.BW;
using HiCupon.BW.Interfaces.DA;

namespace HiCupon.BW.CU
{
    public class ManageUserBW : IManageUserBW
    {
        private readonly IManageUserDA _manageUserDA;

        public ManageUserBW(IManageUserDA manageUserDA)
        {
            _manageUserDA = manageUserDA;
        }
        public async Task<(bool, string)> InsertUser(User user)
        {
            return await _manageUserDA.InsertUser(user);
        }

        public async Task<User> AuthenticateUser(string email, string password)
        {
            return await _manageUserDA.AuthenticateUser(email, password);
        }  
    }
}
