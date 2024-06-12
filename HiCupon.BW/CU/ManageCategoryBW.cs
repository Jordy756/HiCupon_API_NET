using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.BW;
using HiCupon.BW.Interfaces.SG;

namespace HiCupon.BW.CU
{
    public class ManageCategoryBW : IManageCategoryBW
    {
        private readonly IManageCategorySG _manageCategorySG;

        public ManageCategoryBW(IManageCategorySG manageCategorySG)
        {
            _manageCategorySG = manageCategorySG;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _manageCategorySG.GetAllCategories();
        }
    }
}
