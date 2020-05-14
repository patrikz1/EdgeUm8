using Remote_db.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Remote_db.Models
{
    public class AvailableTimes : IIdentifiable<int> { 
        [Key]
        public int Id { get; set; }

        [ForeignKey("Room")]
        public string RoomId { get; set; }
        public virtual HouseRoom Room { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
    }
}