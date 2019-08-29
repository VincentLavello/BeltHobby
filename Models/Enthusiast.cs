using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BeltExam.Models
{
public class Enthusiast
        {
                [Key]
                [Required]
                public int EnthusiastID{get;set;}
                 [ForeignKey("User")]
                public int UserId {get;set;}
                 [ForeignKey("Hobby")]
                public int HobbyID {get;set;}
                [Range(1,10)]
                public int Proficiency {get;set;}

                
                //navigation properties
                public Hobby ThisHobby {get;set;}
                public User Hobbyist {get;set;}
                public Enthusiast(){}
                public Enthusiast(int _HobbyId, int userid, int prof = 1)
                {
                        HobbyID=_HobbyId;
                        UserId=userid;
                        Proficiency=prof;
                        
                }
        }      

}