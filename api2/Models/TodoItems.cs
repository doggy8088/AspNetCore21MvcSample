using System;
using System.Collections.Generic;

namespace api2.Models
{
    public partial class TodoItems
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
