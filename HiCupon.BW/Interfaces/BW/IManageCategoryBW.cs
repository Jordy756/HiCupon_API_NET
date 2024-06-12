
using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.BW
{
    public interface IManageCategoryBW
    {
        Task<IEnumerable<Category>> GetAllCategories();
    }
}
