using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Entities
{
    public class PlayerPosition
    {
        public int FKIdPlayer { get; set; }
        public Player Player {get; set; }
        public int FKIdPosition { get; set; }
        public Position Position{ get; set; }
    }
}