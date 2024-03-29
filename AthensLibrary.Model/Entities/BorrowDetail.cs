﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthensLibrary.Model.Helpers.HelperClasses;
using AthensLibrary.Model.Helpers.HelperInterfaces;

namespace AthensLibrary.Model.Entities
{
    public class BorrowDetail : TimeStamp, ISoftDelete
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public string BorrowerId { get; set; }
        public DateTime BorrowedOn { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
