using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Remote_db.Models
{
    public class Dibs
    {
        [ForeignKey ("AvailableDib")]
        public int AvailabilityId { get; set; }
        public virtual AvailableTimes AvailableDib { get; set; } 

        [ForeignKey("UserDib")]
        public int UserId { get; set; }
        public virtual User UserDib { get; set; }
    }
}