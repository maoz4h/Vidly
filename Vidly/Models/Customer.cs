﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]  // Makes the 'Name' column to be no longer nullable
        [StringLength(256)]
        public string Name { get; set; }

        public bool IsSubsricedToNewletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }          // Foreign key
        
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}