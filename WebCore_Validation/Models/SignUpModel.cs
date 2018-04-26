using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebCore_Validation.CustomAttributes;

namespace WebCore_Validation.Models
{
    public class SignUpModel
    {   [RegularExpression(@"^[A-Za-z\s]{1,50}", ErrorMessage = "First Name cannot include numbers and special characters!")]
        [Display(Name ="First Name")]
        [MaxLength(50, ErrorMessage = "First Name cannot be more than 50 characters!")]
        [Required(ErrorMessage ="Please Enter First Name!")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Za-z\s]{1,50}", ErrorMessage = "Last Name cannot include numbers and special characters!")]
        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "Last Name cannot be more than 50 characters!")]
        [Required(ErrorMessage = "Please Enter Last Name!")]
        public string LastName { get; set; }

        [MinLength(3,ErrorMessage ="UserName must be minimum 3 Characters!")]
        [MaxLength(50, ErrorMessage = "UserName cannot be more than 50 characters!")]
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please Enter UserName!")]
        public string UserName { get; set; }

        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,50}", ErrorMessage = "Atleast one UpperCase,One Digit and One Special Charcter and Total 6 Characters")]
        [MinLength(6, ErrorMessage = "Password must be minimum 6 Characters!")]
        [MaxLength(50,ErrorMessage = "Password cannot be more than 50 characters!")]
        [Required(ErrorMessage = "Please Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please Enter Confirm Password!")]
        [Compare("Password",ErrorMessage ="Password and Confirm Password must match!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Enter Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="Country")]
        [Required(ErrorMessage = "Please Enter Country!")]
        public int CountryId { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please Select City!")]
        public int CityId { get; set; }

        public string Address { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Select Terms&Conditions!")]
        public bool Terms { get; set; }
        
    }
}
