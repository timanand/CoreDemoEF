using System;
using System.ComponentModel.DataAnnotations;


namespace CoreDemoEF.Domain
{
    public class StaffMember
    {
        public int Id { get; set;}


        [Display(Name = "First Name")]
    	[Required(ErrorMessage = "Please enter your first name")]
	    [StringLength(50, MinimumLength = 5)]         
        public string FirstName { get; set; }
        
        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(50, MinimumLength = 5)]   
        public string LastName { get; set; }

        
        public string Title { get; set; }


    }

}
