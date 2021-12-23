using Pharmacy.Domain.Managers.Administration;
using Pharmacy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Login
{
    public class LoginUser
    {
        private static User user = null;
        private LoginUser() { }

        public static User GetUser()
        {
            return user;
        }
        public static bool CreateUser(string Login, string Password)
        {
            UserManager manager = new UserManager();
            var res = manager.All().Where(x => x.Login == Login && x.Password == Password);
            var list = manager.All();
            user = res.Count() > 0 ? res.First() : null;
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public static void SetPharmacy(PharmacyModel ph)
        {
            user.Pharmacy = ph;
        }
    }
}
