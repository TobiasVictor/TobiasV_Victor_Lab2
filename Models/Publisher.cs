﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TobiasV_Victor_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Publisher Name")]
        [StringLength(50)]
        public string PublisherName { get; set; }

        [StringLength(70)]
        public string Adress { get; set; }
        public ICollection<PublishedBook> PublishedBooks { get; set; }
    }
}
