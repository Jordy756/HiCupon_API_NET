using HiCupon.API.DTOs;
using HiCupon.BC.Models;
using HiCupon.DA.Entities;
using HiCupon.DA.Utility;
using System.Net.Sockets;

namespace HiCupon.API.Utility
{
    public class BillMapper
    {
        public static BillDTO MapToBillDTO(Bill bill)
        {
            BillDTO billDTO = new(
                bill.Id,
                new UserDTO(bill.User.Id, bill.User.Name, bill.User.LastName, bill.User.IdentificationCard, bill.User.DateBirth, bill.User.Email, bill.User.Password), /*UserMapper.MapToUserDTO(bill.User),*/
                bill.BasePrice,
                bill.Iva,
                bill.Total,
                BillCouponMapper.MapToBillCouponDTOs(bill.BillCoupons)
            );

            billDTO.BillCouponDTOs = BillCouponMapper.MapToBillCouponDTOs(bill.BillCoupons);

            return billDTO;
        }

        public static Bill MapToBill(BillDTO billDTO)
        {
            Bill bill = new(
                billDTO.Id,
                UserMapper.MapToUser(billDTO.UserDTO), //new User(billDTO.UserDTO.Id, billDTO.UserDTO.Name, billDTO.UserDTO.LastName, billDTO.UserDTO.IdentificationCard, billDTO.UserDTO.DateBirth, billDTO.UserDTO.Email, billDTO.UserDTO.Password),
                billDTO.BasePrice,
                billDTO.Iva,
                billDTO.Total,
                BillCouponMapper.MapToBillCoupons(billDTO.BillCouponDTOs) 
            );

            bill.BillCoupons = BillCouponMapper.MapToBillCoupons(billDTO.BillCouponDTOs);

            return bill;
        }
        public static IEnumerable<BillDTO> MapToBillDTOs(IEnumerable<Bill> bills)
        {
            return bills.Select(bill => MapToBillDTO(bill));
        }

        public static IEnumerable<Bill> MapToBills(IEnumerable<BillDTO> billDTOs)
        {
            return billDTOs.Select(billDTO => MapToBill(billDTO));
        }

    }
}
