﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Mumbi.Domain.Entities
{
    [Table("Tooth")]
    public partial class Tooth
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string ToothId { get; set; }
        [Required]
        [StringLength(50)]
        public string ChildId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GrowDate { get; set; }
        public string Note { get; set; }
        [Column("ImageURL")]
        public string ImageUrl { get; set; }
        public bool GrownFlag { get; set; }

        [ForeignKey(nameof(ChildId))]
        [InverseProperty(nameof(ChildInfo.Teeth))]
        public virtual ChildInfo Child { get; set; }
        [ForeignKey(nameof(ToothId))]
        [InverseProperty(nameof(ToothInfo.Teeth))]
        public virtual ToothInfo ToothNavigation { get; set; }
    }
}
