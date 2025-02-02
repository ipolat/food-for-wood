﻿using System.ComponentModel.DataAnnotations;

namespace deneme4.Data

{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }

    }
}
