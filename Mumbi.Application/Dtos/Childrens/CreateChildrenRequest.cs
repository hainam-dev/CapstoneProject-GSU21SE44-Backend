﻿using System;

namespace Mumbi.Application.Dtos.Childrens
{
    public class CreateChildrenRequest
    {
        public string FullName { get; set; }
        public string NickName { get; set; }
        public string Image { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public int ChildrenStatus { get; set; }
        public DateTime CalculatedBornDate { get; set; }
    }
}
