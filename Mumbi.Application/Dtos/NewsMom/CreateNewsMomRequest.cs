﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbi.Application.Dtos.NewsMom
{
    public class CreateNewsMomRequest
    {
        public string MomId { get; set; }
        public string NewsId { get; set; }
    }
}