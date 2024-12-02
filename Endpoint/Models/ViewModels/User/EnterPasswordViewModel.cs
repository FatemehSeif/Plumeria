using System.ComponentModel.DataAnnotations;

namespace Endpoint.Models.ViewModels.User
{
    public class EnterPasswordViewModel
    {
        
        [Required]
        [Display(Name = "پسورد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

      
 
    }

}