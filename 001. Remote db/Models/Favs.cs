using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Remote_db.Models
{
    public class Favs
    {
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public virtual HouseRoom Room { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}