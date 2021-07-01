﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Mumbi.Domain.Entities
{
    [Table("Action_Child")]
    public partial class ActionChild
    {
        [Key]
        public int Id { get; set; }
        [Column("Child_Id")]
        public int ChildId { get; set; }
        [Column("Action_Id")]
        public int ActionId { get; set; }
        public bool CheckedFlag { get; set; }

        [ForeignKey(nameof(ActionId))]
        [InverseProperty("ActionChildren")]
        public virtual Action Action { get; set; }
        [ForeignKey(nameof(ChildId))]
        [InverseProperty(nameof(ChildInfo.ActionChildren))]
        public virtual ChildInfo Child { get; set; }
    }
}
