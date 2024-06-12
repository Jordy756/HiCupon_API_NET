using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.DA;
using HiCupon.DA.Context;
using HiCupon.DA.Entities;
using Microsoft.EntityFrameworkCore;

namespace HiCupon.DA.Actions
{
    public class ManageUserDA : IManageUserDA
    {
        private readonly HiCouponContext _context;

        public ManageUserDA(HiCouponContext context)
        {
            _context = context;
        }

        public async Task<(bool, string)> InsertUser(User user)
        {
            UserDA userDA = new UserDA
            {
                Name = user.Name,
                LastName = user.LastName,
                IdentificationCard = user.IdentificationCard,
                BirthDate = user.BirthDate,
                Email = user.Email,
                Password = user.Password,
            };

            await _context.UserDAs.AddAsync(userDA);
            var result = await _context.SaveChangesAsync();

            return result > 0 ? (true, "Usuario registrado correctamente") : (false, "Error al registrar usuario");
        }

        public async Task<User> AuthenticateUser(string email, string password)
        {
            return await _context.UserDAs
                .Where(user => user.Email == email && user.Password == password)
                .Select(user => new User(user.Id, user.Name, user.LastName, user.IdentificationCard, user.BirthDate, user.Email, user.Password))
                .FirstOrDefaultAsync() ?? new User();
        }
    }
}
