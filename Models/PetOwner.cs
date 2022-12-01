using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace pet_hotel
{
    public class PetOwner 
    {
        //primary key
        public int id {get; set;}

        //email
        [Required]
        public string emailAddress {get; set;}

        //name
        [Required]
        public string name {get; set;}

        //pet count
        public int petCount {get; set;}


    }
}
