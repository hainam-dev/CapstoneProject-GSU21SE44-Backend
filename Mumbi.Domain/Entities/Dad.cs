﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Mumbi.Domain.Entities
{
    [Table("Dad")]
    public partial class Dad
    {
        public Dad()
        {
            Children = new HashSet<Child>();
        }

        [Key]
        [StringLength(100)]
        public string Id { get; set; }
        [Required]
        [StringLength(200)]
        public string FullName { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthday { get; set; }
        [StringLength(15)]
        public string Phonenumber { get; set; }
        [StringLength(10)]
        public string BloodGroup { get; set; }
        [StringLength(10)]
        public string RhBloodGroup { get; set; }
        [Required]
        [StringLength(50)]
        public string AccountId { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Account.Dad))]
        public virtual Account IdNavigation { get; set; }
        [InverseProperty(nameof(Child.Dad))]
        public virtual ICollection<Child> Children { get; set; }
    }
}
