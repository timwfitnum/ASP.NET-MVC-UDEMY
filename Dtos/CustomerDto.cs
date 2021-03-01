﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using dbStuff.Models;

namespace dbStuff.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Display(Name = "Date of Birth")]
        //[Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribeToNewsletter { get; set; }


        public byte MembershipTypeId { get; set; }
        
        public MembershipTypeDto MembershipType { get; set; }

        
    }
}