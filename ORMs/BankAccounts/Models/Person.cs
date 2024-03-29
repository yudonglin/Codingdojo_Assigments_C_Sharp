using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BankAccounts.Models
{
    public class User{
        [Key]
        public int UserId { get; set; }
        
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name:")] 
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [Display(Name = "Password:")]
        public string Password {get;set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password:")]
        public string Confirm {get;set;}

        public List<Transaction> UserTransaction {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class LoginUser{
        // No other fields!
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string Email {get; set;}
        
        [Required]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    
    public class Transaction{
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int UserId {get;set;}
        public User Creator {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
    }
}