﻿using System;

namespace Mumbi.Application.Dtos.Childrens
{
    public class CreateChildrenRequest
    {
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public string Image { get; set; }
        public string Gender { get; set; }
        public string BirthDay { get; set; }
        public string MomID { get; set; }
        public int ChildrenStatus { get; set; }
        public string BloodGroup { get; set; }
        public string RhBloodGroup { get; set; }
        public int HeadVortex { get; set; }
        public int Fingertips { get; set; }
        public DateTime CalculatedBornDate { get; set; }
        public string PregnancyType { get; set; }
        public int MotherMenstrualCycleTime { get; set; }
    }
}
