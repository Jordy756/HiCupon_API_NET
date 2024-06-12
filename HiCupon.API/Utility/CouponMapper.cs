using HiCupon.API.DTOs;
using HiCupon.BC.Models;

namespace HiCupon.API.Utility
{
    public class CouponMapper
    {
        public static CouponDTO MapToCouponDTO(Coupon coupon)
        {
            return new CouponDTO (
                coupon.Id,
                coupon.Name,
                coupon.Description,
                coupon.Image,
                coupon.CreationDate,
                coupon.ReleaseDate,
                coupon.ExpirationDate,
                coupon.Price,
                coupon.Stock,
                coupon.Location,
                coupon.Discount,
                coupon.IsActive,
                new CategoryDTO(coupon.Category.Id, coupon.Category.Name),
                new CompanyDTO(coupon.Company.Id, coupon.Company.Name),
                coupon.CouponPromotions.Select(couponPromotion => new CouponPromotionDTO (couponPromotion.Id, couponPromotion.Discount, couponPromotion.StartDate, couponPromotion.EndDate, new PromotionDTO(couponPromotion.Promotion.Id, couponPromotion.Promotion.Name)))
            );
        }

        public static IEnumerable<CouponDTO> MapToCouponDTOs(IEnumerable<Coupon> coupons)
        {
            return coupons.Select(MapToCouponDTO);
        }
    }
}
