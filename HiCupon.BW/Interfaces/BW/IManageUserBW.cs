using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.BW
{
    public interface IManageUserBW
    {
        Task<(bool, string)> InsertUser(User user);
        Task<User> AuthenticateUser(string email, string password);
    }
}
