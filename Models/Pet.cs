using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType {
        Schnoodle,
        Puggle,
        Sheapard,
        Sheadle,
        Poodle,
        Beadle,
        Beagle,
        BeaDog,
        Bulldog,
        TerryDog,
        Terrier,
        Toodle,
        Boxer,
        Boxerdoodle,
        Labrador,
        Labradoodle,
        Retriever
    }

    public enum PetColorType {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted,
        Green
    }

    public class Pet {
        public int id {get; set;}
    
        [Required]
        public string name {get; set;}

        [Required]
        public PetBreedType breed {get; set;}

        [Required]
        public PetColorType color {get; set;}

        public DateTime checkedInAt {get; set;}

        [Required]
        [ForeignKey("petOwner")]
        public int petOwnerId {get; set;}

        public PetOwner petOwner {get; set;}

    }
}
