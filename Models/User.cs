using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BeltExam.Models
{
public class User
{
    [Key]
    public int UserId {get;set;}
    [Required]
    [MinLength(2, ErrorMessage="First Name requires 2 characters.")]
    public string FirstName {get;set;}
    [Required]
    [MinLength(2, ErrorMessage="Last Name requires 2 characters.")]
    public string LastName {get;set;}
    [EmailAddress]
    [Required]
    public string Email {get;set;}
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage="Password is min. 8 of Upper, Lower, number, and special character.")]
    // [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
    [RegularExpression(@"(?=^.{8,255}$)((?=.*\d)(?=.*[A-Z])(?=.*[a-z])|(?=.*\d)(?=.*[^A-Za-z0-9])(?=.*[a-z])|(?=.*[^A-Za-z0-9])(?=.*[A-Z])(?=.*[a-z])|(?=.*\d)(?=.*[A-Z])(?=.*[^A-Za-z0-9]))^.*", 
    ErrorMessage = "Password is min. 8 of Upper, Lower, number, and special character.")]
    public string Password {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    // Will not be mapped to your users table.
    public List<Hobby> Hobbies {get;set;}    
    [NotMapped]
    [Compare("Password")]
    [MinLength(8, ErrorMessage="Passwords must match.")]

    [DataType(DataType.Password)]
    public string Confirm {get;set;}
    // public List<Transaction> Transactions {get;set;}
    [NotMapped]
    public string FullName {
        get {return $"{FirstName} {LastName}";}
    }
    public User(){}
    public User(string firstName, string lastName, string email, string pwd)
    {
        FirstName=firstName; 
        LastName=lastName; 
        Email=email; 
        Password=pwd;
    }
    public override string ToString() 
    {
        return $"{this.FirstName} {this.LastName}";
    }

  }//class
}//namespace