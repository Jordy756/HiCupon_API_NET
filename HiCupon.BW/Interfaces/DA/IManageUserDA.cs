using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.DA
{
    public interface IManageUserDA
    {
        Task<(bool, string)> InsertUser(User user);
        Task<User> AuthenticateUser(string email, string password);
    }
}
