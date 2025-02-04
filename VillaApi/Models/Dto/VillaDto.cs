﻿using System.ComponentModel.DataAnnotations;

namespace VillaApi.Models.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
       
    }
}
