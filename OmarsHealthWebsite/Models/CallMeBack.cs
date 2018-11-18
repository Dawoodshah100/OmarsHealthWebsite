using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OmarsHealthWebsite.Models
{
    public class CallMeBack
    {
        [DisplayName("First Name")]
        //[RegularExpression(@"^[a-zA-Z \- \s \']{2,20}$")]
        [Required]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        //[RegularExpression(@"^[a-zA-Z \- \s \']{2,20}$")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Phone Name")]
        //[RegularExpression(@"^(0044|\+?44|0)[127]\d{9}$", ErrorMessage = "Must be in UK Phone Number ")]
        [Required]
        public string PhoneNumber { get; set; }
    }
}