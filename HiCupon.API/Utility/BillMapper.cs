using HiCupon.API.DTOs;
using HiCupon.BC.Models;
using static Azure.Core.HttpHeader;

namespace HiCupon.API.Utility
{
    public class BillMapper
    {
        public static BillDTO MapToBillDTO(Bill bill)
        {
            return new BillDTO(
                bill.Id,
                bill.TotalBasePrice,
                bill.TotalDiscount,
                bill.TotalTax,
                bill.TotalPrice,
                bill.BillCoupons.Select(billCoupon => new BillCouponDTO(
                    billCoupon.Id,
                    new CouponDTO(
                        billCoupon.Coupon.Id,
                        billCoupon.Coupon.Name,
                        billCoupon.Coupon.Description,
                        billCoupon.Coupon.Image,
                        billCoupon.Coupon.CreationDate,
                        billCoupon.Coupon.ReleaseDate,
                        billCoupon.Coupon.ExpirationDate,
                        billCoupon.Coupon.Price,
                        billCoupon.Coupon.Stock,
                        billCoupon.Coupon.Location,
                        billCoupon.Coupon.Discount,
                        billCoupon.Coupon.IsActive,
                        new CategoryDTO(billCoupon.Coupon.Category.Id, billCoupon.Coupon.Category.Name),
                        new CompanyDTO(billCoupon.Coupon.Company.Id, billCoupon.Coupon.Company.Name),
                        billCoupon.Coupon.CouponPromotions.Select(couponPromotion => new CouponPromotionDTO(couponPromotion.Id, couponPromotion.Discount, couponPromotion.StartDate, couponPromotion.EndDate, new PromotionDTO(couponPromotion.Promotion.Id, couponPromotion.Promotion.Name)))
                    ),
                    billCoupon.Quantity,
                    billCoupon.TotalBasePrice,
                    billCoupon.TotalDiscount,
                    billCoupon.TotalTax,
                    billCoupon.TotalPrice
                ))
            );
        }

        public static Bill MapToBill(BillDTO billDTO)
        {
            return new Bill(
                billDTO.Id,
                billDTO.TotalBasePrice,
                billDTO.TotalDiscount,
                billDTO.TotalTax,
                billDTO.TotalPrice,
                billDTO.BillCouponDTOs.Select(billCouponDTO => new BillCoupon(
                    billCouponDTO.Id,
                    new Coupon (billCouponDTO.CouponDTO.Id),
                    billCouponDTO.Quantity,
                    billCouponDTO.TotalBasePrice,
                    billCouponDTO.TotalDiscount,
                    billCouponDTO.TotalTax,
                    billCouponDTO.TotalPrice
                ))
            );
        }

        public static IEnumerable<BillDTO> MapToBillDTOs(IEnumerable<Bill> bills)
        {
            return bills.Select(MapToBillDTO);
        }
    }
}
