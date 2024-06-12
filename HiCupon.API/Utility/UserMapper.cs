using HiCupon.API.DTOs;
using HiCupon.BC.Models;

namespace HiCupon.API.Utility
{
    public class UserMapper
    {
        public static UserDTO MapToUserDTO(User user)
        {
            return new UserDTO(user.Id, user.Name, user.LastName, user.IdentificationCard, user.BirthDate, user.Email, user.Password);
        }

        public static User MapToUser(UserDTO userDTO)
        {
            return new User(userDTO.Id, userDTO.Name, userDTO.LastName, userDTO.IdentificationCard, userDTO.BirthDate, userDTO.Email, userDTO.Password);
        }

        public static IEnumerable<UserDTO> MapToUserDTOs(IEnumerable<User> users)
        {
            return users.Select(MapToUserDTO);
        }

        public static IEnumerable<User> MapToUsers(IEnumerable<UserDTO> userDTOs)
        {
            return userDTOs.Select(MapToUser);
        }
    }
}
