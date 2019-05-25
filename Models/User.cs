using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DojoActivities.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required (ErrorMessage = "Panda name is required!")]
        [MinLength(3, ErrorMessage = "Panda name must be 3 characters or more!")]
        public string Name {get;set;}

        [EmailAddress]
        [Required (ErrorMessage = "Email is required.")]
        public string Email {get;set;}

        [DataType (DataType.Password)]
        [Required (ErrorMessage = "Password is required.")]
        [MinLength (8, ErrorMessage = "Password must be at least 8 characters.")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password must contain at least 1 uppercase, 1 lowercase and 1 number")]
        public string Password {get;set;}


        [NotMapped]
        [DataType (DataType.Password)]
        [Compare ("Password", ErrorMessage = "Password Confirmation must be the same as the Password!")]
        public string PwConfirmation {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;


        public List<Participant> Participants {get;set;}
    }

    public class UserLogin
    {
        [Required(ErrorMessage = "Invalid Email")]
        public string LoginEmail {get;set;}

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Invalid Password")]
        public string LoginPassword {get;set;}
    }
}