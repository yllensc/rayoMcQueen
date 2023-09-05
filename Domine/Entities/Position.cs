using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Entities
{
    public class Position : BaseEntity
    {
        public string NamePosition { get; set; }
        public ICollection<PlayerPosition> PlayerPositions{ get; set;}
    }
}