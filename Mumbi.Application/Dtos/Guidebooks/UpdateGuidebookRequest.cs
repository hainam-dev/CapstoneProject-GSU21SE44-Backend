﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbi.Application.Dtos.Guidebooks
{
    public class UpdateGuidebookRequest
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string GuidebookContent { get; set; }
        public string ImageURL { get; set; }
        public short EstimatedFinishTime { get; set; }
        public string LastModifiedBy { get; set; }
        public int TypeId { get; set; }
    }
}
