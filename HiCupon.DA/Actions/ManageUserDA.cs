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

        public async Task<string> InsertUser(User user)
        {
            UserDA userDA = new UserDA
            {
                Name = user.Name,
                LastName = user.LastName,
                IdentificationCard = user.IdentificationCard,
                DateBirth = user.DateBirth,
                Email = user.Email,
                Password = user.Password,
            };

            await _context.UserDAs.AddAsync(userDA);
            if (await _context.SaveChangesAsync() == 0) throw new Exception("Error al crear la cuenta");

            return "Cuenta creada correctamente";
        }

        public async Task<User> AuthenticateUser(string email, string password)
        {
            User user = await _context.UserDAs
                .Where(user => user.Email == email && user.Password == password)
                .Select(user => new User(user.Id, user.Name, user.LastName, user.IdentificationCard, user.DateBirth, user.Email, user.Password))
                .FirstOrDefaultAsync() ?? new User();

            if (user.Id == 0) throw new Exception("Correo y contraseña incorrectos");

            return user;
        }
    }
}
