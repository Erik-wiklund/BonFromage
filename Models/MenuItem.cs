using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonFromage.Models
{
    public class MenuItem
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Maträtt")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Lång beskrivning")]
        public string ShortDescription {get;set;}

        [Required]
        [Display(Name = "Beskrivning")]
        public string LongDescription {get;set;}

        [DataType(DataType.ImageUrl)]
        public string ImageUrl {get;set;}

        [Required]
        [Range(30, 999)]
        [Display(Name = "Pris")]
        [DataType(DataType.Currency)]
        public decimal? SellingPrice {get;set;}

        [Required]
        [Range(0, 100)]
        public decimal? ProductionPrice {get;set;}
    }
}