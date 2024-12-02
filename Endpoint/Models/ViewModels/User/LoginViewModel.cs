using System.ComponentModel.DataAnnotations;

namespace Endpoint.Models.ViewModels.User
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "لطفا شماره موبایل خود را وارد نمایید")]
        [Display(Name = "شماره موبایل")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        

        public string ReturnUrl { get; set; }
    }


}
