using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Threading;

namespace BeltExam.Models
{
public class Hobby
    {
        [Key]
        [Required]
        public int HobbyID  {get;set;}
        [Required]
        public string HobbyTitle {get;set;}
        [Required]
        public string Description{get;set;}
        public int Proficiency{get;set;}
        public List<Enthusiast> Members {get;set;}
        //COORDINATOR

        public Hobby(){}
        public Hobby(int _HobbyID , string _HobbyTitle, string _Description, int _prof=1) {
                HobbyID =_HobbyID;
                HobbyTitle=_HobbyTitle;
                Description=_Description;
                Proficiency=_prof;
            }  
                
    }//class
}//namespace