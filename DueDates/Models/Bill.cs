using System;
using System.Collections.Generic;
using System.Text;

namespace DueDates.Models
{
    public class Bill
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public bool IsRecuring { get; set; }
    }
}
