
using System.ComponentModel.DataAnnotations;


namespace YMS5177_CMS.Web.Models.Dtos
{
    public class Login
    {
        [Required(ErrorMessage = "Must type into password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Must type into user name")]
        [Display(Name = "User Name")]
        [MinLength(3, ErrorMessage = "Minimum lengnt is 3")]
        public string UserName { get; set; }

        public string ReturnUrl { get; set; }
    }
}
