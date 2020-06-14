using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuirkyBookRental.Models
{
    public class Book
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Availability { get; set; }


        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd MMM yyyy}")]
        public DateTime DateAdded { get; set; }

        // Navigation  property
        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }
        //

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd MMM yyyy}")]
        public DateTime PublicationDate { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        public string ProductDimensions { get; set; }

    }
}