using HiCupon.BC.Models;

namespace HiCupon.BC.BusinessRules
{
    public class UserRules
    {
        public static bool ValidateUser(User user)
        {
            if (string.IsNullOrEmpty(user.Name)) throw new Exception("El nombre del cliente no puede ir vacío");
            if (string.IsNullOrEmpty(user.LastName)) throw new Exception("El apellido del cliente no puede ir vacío");
            if (string.IsNullOrEmpty(user.IdentificationCard)) throw new Exception("La identificación del cliente no puede ir vacía");
            if (user.BirthDate == DateTime.MinValue) throw new Exception("La fecha de nacimiento del cliente no puede ir vacía");

            return true;
        }

        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) throw new Exception("El email del cliente no puede ir vacío");
            if (!email.Contains("@")) throw new Exception("El email del cliente no es válido");

            return true;
        }

        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password)) throw new Exception("La contraseña del cliente no puede ir vacía");
            if (password.Length < 8) throw new Exception("La contraseña del cliente debe tener al menos 8 caracteres");
            if (password.Length >= 12) throw new Exception("La contraseña del cliente no puede tener más de 12 caracteres");

            return true;
        }
    }
}
