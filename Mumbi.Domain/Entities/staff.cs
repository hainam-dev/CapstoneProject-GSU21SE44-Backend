﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Mumbi.Domain.Entities
{
    [Table("Staff")]
    public partial class Staff
    {
        [Key]
        [StringLength(100)]
        public string AccountId { get; set; }
        [Required]
        [StringLength(200)]
        public string FullName { get; set; }
        [StringLength(50)]
        public string Phonenumber { get; set; }
        public string Image { get; set; }
        [StringLength(50)]
        public string Birthday { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("Staff")]
        public virtual Account Account { get; set; }
    }
}
