﻿using AthensLibrary.Model.Enumerators;
using AthensLibrary.Model.Helpers.HelperClasses;
using AthensLibrary.Model.Helpers.HelperInterfaces;
using System;

namespace AthensLibrary.Model.Entities
{
    public class User : UserTimeStamp, ISoftDelete
    {       
        public string FullName { get; set; }
        public Gender Gender { get; set; }        
        public DateTime DateOfBirth { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public string BorrowerId { get; set; }
        public byte BorrowCount { get; set; } = default;
        public bool IsActive { get; set; }
    }
}
