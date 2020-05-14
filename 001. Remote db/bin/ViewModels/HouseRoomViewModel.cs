using Remote_db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Remote_db.ViewModels
{
    public class HouseRoomViewModel
    {
        public int HouseId { get; set; }
        public bool Projector { get; set; }
        public bool WhiteBoard { get; set; }
        public List<AvailableTimes> FreeTimes { get; set; }
    }
}