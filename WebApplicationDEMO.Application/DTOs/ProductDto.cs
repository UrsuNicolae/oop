﻿using System.ComponentModel.DataAnnotations;

namespace WebApplicationDEMO.Application.DTOs
{
    public class ProductDto
    {
        public int? Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
