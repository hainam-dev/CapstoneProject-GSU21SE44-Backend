﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Mumbi.Domain.Entities
{
    [Table("PregnancyActivity")]
    public partial class PregnancyActivity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string ChildId { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [Column("MediaFileURL")]
        public string MediaFileUrl { get; set; }
        public int TypeId { get; set; }
        public bool FinishedFlag { get; set; }
        public bool DelFlag { get; set; }

        [ForeignKey(nameof(ChildId))]
        [InverseProperty(nameof(ChildInfo.PregnancyActivities))]
        public virtual ChildInfo Child { get; set; }
        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(PregnancyActivityType.PregnancyActivities))]
        public virtual PregnancyActivityType Type { get; set; }
    }
}
