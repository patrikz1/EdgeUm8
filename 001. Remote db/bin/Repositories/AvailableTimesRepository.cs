using Remote_db.Models;
using Remote_db.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Remote_db {
    public class AvailableTimesRepository : Repository<AvailableTimes, int>
    {
        public AvailableTimesRepository(ApplicationDbContext context) : base(context) { }

        public List<AvailableTimes> GetAllTimesByRoomId(string roomId) {
            return items.Where((t) => t.Room.Equals(roomId)).ToList();
        }
    }
}