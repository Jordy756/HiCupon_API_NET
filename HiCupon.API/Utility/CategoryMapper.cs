using HiCupon.API.DTOs;
using HiCupon.BC.Models;

namespace HiCupon.API.Utility
{
    public class CategoryMapper
    {
        public static CategoryDTO MapToCategoryDTO(Category category)
        {
            return new CategoryDTO(category.Id, category.Name);
        }

        public static IEnumerable<CategoryDTO> MapToCategoryDTO(IEnumerable<Category> categories)
        {
            return categories.Select(MapToCategoryDTO);
        }
    }
}
