﻿
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class SocialActivist
{
    public int Id { get; set; }
        public string User_id { get; set; } = null!;

        [Required]
        [EmailAddress(ErrorMessage = "Enter the valid e-mail address.")]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(50, ErrorMessage = "Address is too long, 50 charachters maximum.")]
        public string Address { get; set; } = null!;
    
        [Required]
        [MaxLength(15, ErrorMessage = "Phone is too long, 15 charachters maximum.")]
        public string Phone { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Twitter account is too short, 4 charachters minimum.")]
        [MaxLength(15, ErrorMessage = "Twitter account is too long, 15 charachters maximum.")]
        public string Twitter { get; set; }

    }