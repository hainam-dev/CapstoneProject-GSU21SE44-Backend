﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbi.Application.Dtos.Tokens
{
    public class FcmTokenResponse
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FcmToken { get; set; }
    }
}
