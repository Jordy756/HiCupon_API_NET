using HiCupon.BC.Models;

namespace HiCupon.BC.BusinessRules
{
    public class BillRules
    {
        public static bool ValidateBill(Bill bill)
        {
            //if (bill.User.Id <= 0) throw new Exception("El id del usuario no puede ser menor o igual a 0");
            //if (bill.BasePrice <= 0) throw new Exception("El precio base de la factura no puede ser menor o igual a 0");
            //if (bill.Iva <= 0) throw new Exception("El IVA de la factura no puede ser menor o igual a 0");
            //if (bill.Total <= 0) throw new Exception("El precio total de la factura no puede ser menor o igual a 0");
            
            return true;
        }

        /*
        public static bool ValidateUserId(int userId)
        {
            if (userId <= 0) throw new Exception("El id del customer no puede ser menor o igual a 0");

            return true;
        }
        */
    }
}
