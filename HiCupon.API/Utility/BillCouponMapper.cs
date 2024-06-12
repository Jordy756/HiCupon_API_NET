using HiCupon.API.DTOs;
using HiCupon.BC.Models;
using HiCupon.DA.Entities;

namespace HiCupon.API.Utility
{
    public class BillCouponMapper
    {
        public static BillCouponDTO MapToBillCouponDTO(BillCoupon billCoupon)
        {
            return new BillCouponDTO();
            //BillCouponDTO billCouponDTO = new(
            //    billCoupon.Id,
            //    BillMapper.MapToBillDTO(billCoupon.Bill),
            //    billCoupon.Coupon,
            //    billCoupon.Quantity
            //);

            //return billCouponDTO;
        }

        public static BillCoupon MapToBillCoupon(BillCouponDTO billCouponDTO)
        {
            return new BillCoupon();
            //BillCoupon billCoupon= new(
            //    billCouponDTO.Id,
            //    new Bill( billCouponDTO.BillDTO.Id, UserMapper.MapToUser(billCouponDTO.BillDTO.UserDTO), billCouponDTO.BillDTO.BasePrice, billCouponDTO.BillDTO.Iva, billCouponDTO.BillDTO.Total, MapToBillCoupons(billCouponDTO.BillDTO.BillCouponDTOs)),
            //    billCouponDTO.CouponDTO,
            //    billCouponDTO.Quantity
            //);

            //return billCoupon;
        }

        public static IEnumerable<BillCouponDTO> MapToBillCouponDTOs(IEnumerable<BillCoupon> billCoupons)
        {
            return billCoupons.Select(billCoupon => MapToBillCouponDTO(billCoupon));
        }

        public static IEnumerable<BillCoupon> MapToBillCoupons(IEnumerable<BillCouponDTO> billCouponDTOs)
        {
            return billCouponDTOs.Select(billCouponDTO => MapToBillCoupon(billCouponDTO)).ToList();
        }
    }
}
