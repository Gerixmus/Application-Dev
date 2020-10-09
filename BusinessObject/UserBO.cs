using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class UserBO
    {
        public int UserId { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }
        [Display(Name = "User Address")]
        [Required(ErrorMessage = "User Address is required")]
        public string UserAddress { get; set; }
        [Display(Name = "User Email")]
        [Required(ErrorMessage = "User Email is required")]
        [EmailAddress(ErrorMessage = "Please enter valid email address")]
        public string UserEmail { get; set; }
        [Display(Name = "User Phone Number")]
        [Required(ErrorMessage = "User Phone Number is required")]
        public string UserMobile { get; set; }
    }
}
