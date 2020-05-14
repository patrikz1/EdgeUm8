using Remote_db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Remote_db.ViewModels
{
    public class HouseViewModel
    {
        public string HouseName { get; set; }

        public TimeSpan Opens { get; set; }

        public TimeSpan Closes { get; set; }

        public byte[] MapPic { get; set; }

        public List<HouseRoomViewModel> Rooms { get; set; }
    }
}