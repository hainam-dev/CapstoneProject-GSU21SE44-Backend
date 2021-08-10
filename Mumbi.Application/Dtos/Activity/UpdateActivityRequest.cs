﻿namespace Mumbi.Application.Dtos.Activity
{
    public class UpdateActivityRequest
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }
        public string MediaFileURL { get; set; }
        public int TypeId { get; set; }
        public byte SuitableAge { get; set; }
    }
}