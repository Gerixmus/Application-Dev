using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAL
    {
        private UserDBEntities objUserDbEntities;
        public UserDAL()
        {
            objUserDbEntities = new UserDBEntities();
        }
        public CustomBO AddUser(UserBO objUserBo)
        {
            CustomBO objCustomBo = new CustomBO();
            Users objUser = new Users()
            {
                UserAddress = objUserBo.UserAddress,
                UserEmail = objUserBo.UserEmail,
                UserMobile = objUserBo.UserMobile,
                UserName = objUserBo.UserName,
            };
            objUserDbEntities.Users.Add(objUser);
            int returnValue = objUserDbEntities.SaveChanges();
            if (returnValue > 0)
            {
                objCustomBo.CustomMessage = "Data Succesfully Added";
                objCustomBo.CustomMessageNumber = returnValue;
            }
            else
            {
                objCustomBo.CustomMessage = "There was some problem";
                objCustomBo.CustomMessageNumber = returnValue;
            }
            return objCustomBo;
        }
    }
}
