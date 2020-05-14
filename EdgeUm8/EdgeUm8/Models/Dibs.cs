using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgeUm8.Models
{
    public class Dibs
    {
        [ForeignKey(typeof(AvailableTimes))]
        public int AvailabilityId { get; set; }

        [ForeignKey(typeof(User))]
        public int UserId { get; set; }
    }
}
