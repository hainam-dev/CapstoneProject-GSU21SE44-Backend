﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Mumbi.Domain.Entities
{
    [Table("Token")]
    public partial class Token
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("User_Id")]
        [StringLength(100)]
        public string UserId { get; set; }
        [Required]
        public string FcmToken { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Tokens")]
        public virtual User User { get; set; }
    }
}
