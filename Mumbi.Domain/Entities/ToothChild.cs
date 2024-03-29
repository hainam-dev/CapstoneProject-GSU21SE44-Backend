﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Mumbi.Domain.Entities
{
    [Table("ToothChild")]
    public partial class ToothChild
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ToothId { get; set; }

        [Required]
        [StringLength(50)]
        public string ChildId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? GrownDate { get; set; }

        public string Note { get; set; }

        [Column("ImageURL")]
        public string ImageUrl { get; set; }

        public bool GrownFlag { get; set; }

        [ForeignKey(nameof(ChildId))]
        [InverseProperty(nameof(ChildInfo.ToothChildren))]
        public virtual ChildInfo Child { get; set; }

        [ForeignKey(nameof(ToothId))]
        [InverseProperty(nameof(ToothInfo.ToothChildren))]
        public virtual ToothInfo Tooth { get; set; }
    }
}