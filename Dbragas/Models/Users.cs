﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBragas.Models
{
    public partial class Users
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(120)]
        [Unicode(false)]
        public string Name { get; set; }
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string Email { get; set; }
        [Required]
        [StringLength(14)]
        [Unicode(false)]
        public string Password { get; set; }
        [Required]
        [StringLength(120)]
        [Unicode(false)]
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}